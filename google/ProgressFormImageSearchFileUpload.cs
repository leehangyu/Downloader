using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProgressFormGoogleDownloaderFileUpload : Form
    {
        protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Main parentForm;
        private HttpWebRequest httpWebRequest;
        private HttpWebResponse httpWebResponse;
        private string imgurAddress;
        private JObject jsonObject;
        private string link;
        private Stream requestStream;
        private string resString;
        private byte[] sendData;
        private StreamReader streamReader;
        private string uploadFilePath;
        private WebResponse webResponse;

        public ProgressFormGoogleDownloaderFileUpload(Main _parentForm, string _filePath)
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();

            CheckForIllegalCrossThreadCalls = false;

            this.parentForm = _parentForm;
            this.uploadFilePath = _filePath;

        }

        private async void uploadToImgur_dot_com()
        {
            log.Debug("uploadToImgur_dot_com()");
            try
            {
                sendData = File.ReadAllBytes(uploadFilePath);
                imgurAddress = "https://api.imgur.com/3/upload";
                httpWebRequest = (HttpWebRequest)WebRequest.Create(@imgurAddress);
                httpWebRequest.Host = "api.imgur.com";
                httpWebRequest.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.124 Safari/537.36";
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.Headers.Add("Authorization", "Client-ID 8a6226eb8fd533b");
                httpWebRequest.ContentLength = sendData.Length;
                httpWebRequest.Method = "POST";

                requestStream = httpWebRequest.GetRequestStream();
                requestStream.Write(sendData, 0, sendData.Length);
                requestStream.Close();

                webResponse = await httpWebRequest.GetResponseAsync();
                httpWebResponse = (HttpWebResponse)webResponse;

                log.Debug(httpWebResponse.StatusCode);

                if (httpWebResponse.StatusCode == HttpStatusCode.OK)
                {
                    streamReader = new StreamReader(httpWebResponse.GetResponseStream(), Encoding.GetEncoding("UTF-8"));
                    resString = streamReader.ReadToEnd();
                    jsonObject = JObject.Parse(resString);
                    link = (string)jsonObject["data"]["link"];
                    //log.DebugLine(link);
                    parentForm.setGoogleDownloaderFileLinkUpdate(link);
                    parentForm.picBoxUploadedUpdate(uploadFilePath);
                }
                else
                {
                    MessageBox.Show(this, "upload failed! :" + httpWebResponse.StatusCode);
                }
                requestStream.Close();
                httpWebResponse.Close();

                //log.DebugLine("uploadToImgur_dot_com()");
                //this.Dispose();
                this.Close();
            } catch (Exception e)
            {
                log.Debug(e.ToString());
                MessageBox.Show(this, e.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }

        private void ProgressFormGoogleDownloaderFileUpload_Load(object sender, EventArgs e)
        {
            Thread t1 = new Thread(new ThreadStart(uploadToImgur_dot_com));
            t1.Start();
            //uploadToImgur_dot_com();
        }

    }
}
