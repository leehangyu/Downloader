using log4net;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProgressFormGoogleDownloaderFromURI : Form
    {
        protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Uri fromURI;
        private Main parentForm;
        private WebRequest webRequest;
        private HttpWebRequest httpWebRequest;
        private HttpWebResponse httpWebResponse;
        private Stream stReadData;
        private StreamReader srReadData;
        private Regex regex;
        private MatchCollection mc;
        private string strResult;
        private IdnMapping idn;
        private bool stopFlag = false;
        private int imageCount;

        public ProgressFormGoogleDownloaderFromURI(Main _parentForm, Uri _fromURI, int _imageCount)
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();

            this.parentForm = _parentForm;
            this.fromURI = _fromURI;
            this.imageCount = _imageCount;
            idn = new IdnMapping();

            CheckForIllegalCrossThreadCalls = false;
        }

        private void ProgressFormGoogleDownloaderFromURI_Load(object sender, EventArgs e)
        {
            log.Debug("ProgressFormGoogleDownloaderFromURI_Load");

            Thread t1 = new Thread(new ThreadStart(googleGoogleDownloaderDo));
            t1.Start();
            //googleGoogleDownloaderDo();
        }

        private WebRequest getHttpWebRequest(string url)
        {
            try
            {
                webRequest = WebRequest.Create(new Uri(url));
                httpWebRequest = (HttpWebRequest)webRequest;

                //httpWebRequest.Credentials = CredentialCache.DefaultCredentials;
                httpWebRequest.Accept = "Accept:text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,**;q=0.8";
                httpWebRequest.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_3) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                httpWebRequest.ContentType = "text/html; charset=utf-8";
                httpWebRequest.Timeout = 5000;

                return webRequest;
            } catch(UriFormatException e)
            { 
                log.Debug(e.ToString());
                MessageBox.Show("Server connect failed. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        //async await

        private async void googleGoogleDownloaderDo()
        {
            log.Debug("googleGoogleDownloaderDo");
            //폴더 생성
            string savePath = makeSaveDir();

            // 구글 이미지 검색
            string imageURL = "https://www.google.co.kr/searchbyimage?image_content=&filename=&image_url=" + fromURI;
            //log.DebugLine(imageURL);

            log.Debug(imageURL);


            webRequest = getHttpWebRequest(imageURL);
            if(webRequest==null)
            {
                this.Close();
                return;
            }
            httpWebResponse = (HttpWebResponse) await httpWebRequest.GetResponseAsync();

            stReadData = httpWebResponse.GetResponseStream();
            srReadData = new StreamReader(stReadData, Encoding.UTF8);

            strResult = srReadData.ReadToEnd();

            httpWebResponse.Close();
            stReadData.Close();
            srReadData.Close();

            // 2016.12.23
            /*
             * <a class="iu-card-header" href="/search?tbs=simg:CAESqAIJM26FhC-h-XIanAILEKjU2AQaAggIDAsQsIynCBpiCmAIA
             * xIo0QbHErQd0AazHdMG0ganApwBoQLWIcsokCnrNJEi-jPPIew_14jSbIBowgxEagV90DUyRcooJEXLvPaAV3gv9jjYgQt1
             * gKsRTl6V1BvnRYguAYyG3v9XH4zHuIAQMCxCOrv4IGgoKCAgBEgQp_1UPFDAsQne3BCRqJAQoXCgVmcnVpdNqliPYD
             * CgoIL20vMDJ4d2IKGAoFYXBwbGXapYj2AwsKCS9tLzAxNGoxbQogCg1uYXR1cmFsIGZvb2Rz2qWI9gMLCgkvbS8wOHR
             * sYmoKGgoHcHJvZHVjZdqliPYDCwoJL20vMDM2cWg4ChYKBGZvb2TapYj2AwoKCC9tLzAyd2JtDA&amp;q=buah+apel
             * &amp;tbm=isch&amp;sa=X&amp;ved=0ahUKEwiY6PScu4nRAhVIS7wKHSOLAWYQsw4IMA">유사한 이미지</a>
             */

            parentForm.kryptonListBoxGoogleDownloader.Items.Clear();

            string regexString = "<a class=\"iu-card-header\" href=\"([^\"]*)";
            regex = new Regex(regexString, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            mc = regex.Matches(strResult);

            string requstURL = "";
            foreach (Match m in mc)
            {
                if (m.Value.IndexOf("<a class=\"iu-card-header\" href=\"/search?tbs=simg") > -1)
                {
                    requstURL = m.Value.Replace("&amp;", "&");
                    requstURL = requstURL.Replace("<a class=\"iu-card-header\" href=\"/search?", "https://www.google.com/search?newwindow=1&hl=ko&");
                    requstURL = requstURL + "&biw=1752&bih=1114";
                    break;
                }
            }

            for (int startVal = 0; startVal < imageCount+50; startVal += 100)
            {
                string reqURL = requstURL + "&ijn=" + (startVal / 100) + "&start=" + startVal;
                //log.DebugLine("r: " + reqURL);

                webRequest = getHttpWebRequest(reqURL);
                if (webRequest == null)
                {
                    this.Close();
                    return;
                } 

                httpWebResponse = (HttpWebResponse) await httpWebRequest.GetResponseAsync();

                stReadData = httpWebResponse.GetResponseStream();
                srReadData = new StreamReader(stReadData, Encoding.UTF8);

                strResult = srReadData.ReadToEnd();

                httpWebResponse.Close();
                stReadData.Close();
                srReadData.Close();
                
                //결과 있으면.
                if (strResult.Length > 0)
                {
                    regexString = "\"ou\":\"([^\"]*)";
                    Regex regex = new Regex(regexString, RegexOptions.IgnoreCase | RegexOptions.Singleline);
                    MatchCollection mc = regex.Matches(strResult);

                    String imgURL;

                    List<String> retVal = new List<string>();

                    foreach (Match m in mc)
                    {
                        imgURL = WebUtility.UrlDecode(m.Value).Replace("\"ou\":\"", "");
                        parentForm.kryptonListBoxGoogleDownloader.Items.Add(imgURL);
                    }
                }

            }

            int saveFileCount = 0;
            bool success = false;
            string fileName = null;
            for ( int saveIndex=0;saveIndex<parentForm.kryptonListBoxGoogleDownloader.Items.Count;saveIndex++)
            {

                if (stopFlag)
                    break;

                fileName = savePath + "\\" + getRandomNum();
                parentForm.kryptonListBoxGoogleDownloader.SelectedIndex = saveIndex;
                success = getDownloadImage(parentForm.kryptonListBoxGoogleDownloader.SelectedItem.ToString(), fileName);

                if (success)
                {
                    // 파일 받았으면.
                    saveFileCount++;
                }

                //log.DebugLine("saveFileICount: " + saveFileCount);
                if (saveFileCount == imageCount)
                    break;
                
            }
            var requestCount = parentForm.kryptonTextBoxImageCountURL.Text;
            parentForm.kryptonListBoxGoogleDownloader.Items.Clear();

            var text = string.Format("request: {0}, saved: {1}", requestCount, saveFileCount);
            MessageBox.Show(text, "finish", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool getDownloadImage(string downURL, string filePathName)
        {
            // 이미지 다운로드 
            WebClient myWebClient = new WebClient();
            byte[] data;
            string fileExtention;
            string saveFilePath;
            Uri downURI = null;
            try
            {
                downURI = getUrlForPunyCode(downURL);
                //data = await myWebClient.DownloadDataTaskAsync(downURI);
                data = myWebClient.DownloadData(downURI);
                fileExtention = getImageFileType(data);
                saveFilePath = filePathName + fileExtention;
                File.WriteAllBytes(saveFilePath, data);

                if (!(fileExtention == ".unknow.txt"))
                {
                    parentForm.pictureBoxGoogleDownloaderUpdate(saveFilePath);    // 화면 표시
                    return true;
                }
                else
                {
                    File.Delete(saveFilePath);
                    return false;
                }                
            }
            catch (Exception e)
            {
                log.Debug(downURI.ToString());
                log.Debug(e.ToString());
                return false;
            }
        }
        

        private Uri getUrlForPunyCode(string url)
        {
            Uri uri = new Uri(url);
            String replaceURL = uri.OriginalString;
            replaceURL = replaceURL.Replace(uri.Host, idn.GetAscii(uri.Host));
            return new Uri(replaceURL);
        }


        private string getImageFileType(byte[] data)
        {
            string retVal = ".unknow.txt";

            if (data[0] == (char)0xff && data[1] == (char)0xd8)
            {
                retVal = ".jpg";
            }
            else if (data[0] == (char)0x42 && data[1] == (char)0x4d)
            {
                retVal = ".bmp";
            }
            else if (data[0] == (char)0x89 && data[1] == (char)0x50)
            {
                retVal = ".png";
            }
            //else if (data[0] == (char)0x47 && data[1] == (char)0x49)
            //{
            //    retVal = ".gif";
            //}
            else
            {
                retVal = ".unknow.txt";
            }

            return retVal;
        }

        public string makeSaveDir()
        {
            //Uri uri = new Uri(parentForm.textBoxGoogleDownloaderURL.Text);

            // 저장위치 경로.
            //string val = parentForm.textBoxSavePath.Text + "\\" + uri.AbsolutePath.Replace("/", "");
            string val = parentForm.kryptonTextBoxGoogleDownloaderSavePath.Text;
            if (!Directory.Exists(@val))
                Directory.CreateDirectory(@val);
            return val;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            stopFlag = true;
        }

        private string getRandomNum()
        {
            var now = DateTime.Now.ToBinary().ToString();
            return now.Substring(8, 12);
        }
    }
}
