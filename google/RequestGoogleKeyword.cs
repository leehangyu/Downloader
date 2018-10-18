using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;
using log4net;

namespace WindowsFormsApplication1
{
    public class RequestGoogleKeyword
    {
        protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Main mainForm;
        private IdnMapping idn; // 퓨니코드 한글도메인..
        public RequestGoogleKeyword(Main _mainForm)
        {
            log4net.Config.XmlConfigurator.Configure();
            mainForm = _mainForm;
            idn = new IdnMapping();

            //getUrlForPunyCode("http://경북사과.kr/data/item/1442369513/thumb-main_315x300.jpg");
        }

        public List<String> getImageUrlList(string text, int imageCount)
        {

            //listBoxKeyword.Items[index].BackColor = System.Drawing.Color.Red;        
            List<String> allList = new List<string>();
            List<String> temp;
            for (int startVal = 0; startVal < imageCount+50; startVal += 100) // 1200
            {
                temp = getResponse(text, startVal);
                if (temp != null)
                {
                    allList = allList.Union(temp).ToList();
                }
            }

            Debug.WriteLine("allList.Count: " + allList.Count);
            if (allList.Count > 0)
                return allList;

            return null;
        }


        private List<String> getResponse(String keyword, int start)
        {
            StringBuilder dataParams = new StringBuilder();
            // 요청 String -> 요청 Byte 변환
            byte[] byteDataParams = UTF8Encoding.UTF8.GetBytes(dataParams.ToString());

            // 검색 조건 params
            string searchParams = getGoogleDownloaderParamParse();

            // googleURL + "&ijn=" + IntToStr(startVal / 100) + "&start=" + IntToStr(startVal); // 이미지 검색 1000개 URL params.
            String googleURL = "https://www.google.co.kr/search?newwindow=1&hl=ko&site=imghp&tbm=isch&source=hp&biw=1336&bih=877&q=" + keyword + "&ijn=" + (start / 100) + "&start=" + start + searchParams;
            WebRequest webRequest = WebRequest.Create(googleURL);
            HttpWebRequest request = (HttpWebRequest)webRequest;

            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            request.UserAgent = "Mozilla/5.0 (Macintosh; Intel Mac OS X 10_10_2) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/42.0.2311.135 Safari/537.36";
            request.Referer = "https://www.google.co.kr/";
            request.ContentType = "text/html; charset=UTF-8";

            Debug.WriteLine(request.RequestUri);

            // 요청, 응답 받기
            HttpWebResponse response = (HttpWebResponse) request.GetResponse();
            
            // 응답 Stream 읽기
            Stream stReadData = response.GetResponseStream();
            
            StreamReader srReadData = new StreamReader(stReadData, Encoding.UTF8);

            // 응답 Stream -> 응답 String 변환
            string strResult = srReadData.ReadToEnd();
 

            String regexString = "\"ou\":\"([^\"]*)";
            Regex regex = new Regex(regexString, RegexOptions.IgnoreCase | RegexOptions.Singleline);
            MatchCollection mc = regex.Matches(strResult);
            
            String imgURL;

            List<String> retVal = new List<string>();

            foreach (Match m in mc)
            {
                imgURL = WebUtility.UrlDecode(m.Value).Replace("\"ou\":\"", ""); 
                retVal.Add(imgURL);
            }

            if (retVal.Count > 0)
                return retVal;

            return null;
        }

        private string getGoogleDownloaderParamParse()
        {
            string extParam = "";
            string temp = "";
            
            //tbs=islt:svga,isz:ex,iszw:600,iszh:500
            //이미지 크기
            if ( mainForm.kryptonComboBoxSize.SelectedIndex > 0 )
            {
                string size = mainForm.kryptonComboBoxSize.Items[mainForm.kryptonComboBoxSize.SelectedIndex].ToString();

                string[] arSize = size.Split('x');
                temp += "islt:svga,isz:ex,iszw:" + arSize[0];
                temp += ",iszh:" + arSize[1];
            }
            /*
            // tbs=ic:specific,isc:yellow
            //이미지 색상

            if (mainForm.kryptonComboBoxColor.SelectedIndex > 0)
            {
                string color = mainForm.kryptonComboBoxColor.Items[mainForm.kryptonComboBoxColor.SelectedIndex].ToString();

                if(temp.Length>0)
                    temp += ",ic:specific,isc:" + color;
                else
                    temp += "ic:specific,isc:" + color;
            }
            */

            if (temp.Length>0)
                extParam = "&tbs=" + temp;

            return extParam;
        }

        public bool getDownloadImage(string downURL, string filePathName)
        {
            // 이미지 다운로드 
            WebClient myWebClient = new WebClient();
            byte[] data;
            string fileExtention;
            string saveFilePath;
            Uri downURI = getUrlForPunyCode(downURL);
            try
            {
                data = myWebClient.DownloadData(downURI);
                fileExtention = getImageFileType(data);
                saveFilePath = filePathName + fileExtention;
                File.WriteAllBytes(saveFilePath, data);

                //Debug.WriteLine(fileExtention);
                if(!(fileExtention == ".unknow.txt"))
                {
                    mainForm.picBoxUpdate(saveFilePath);    // 화면 표시
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

            try
            {
                replaceURL = replaceURL.Replace(uri.Host, idn.GetAscii(uri.Host));
            }
            catch (ArgumentException ex)
            {
                log.Debug(ex.ToString());
            }   
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
           // {
           //     retVal = ".gif";
           // }
            else
            {
                retVal = ".unknow.txt";
            }

            return retVal;
        }
        
    }

}
