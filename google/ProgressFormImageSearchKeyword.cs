using log4net;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class ProgressFormGoogleDownloaderKeyword : Form
    {
        protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private Main parentForm;
        private RequestGoogleKeyword reqGoogle;
        private int imageCount;
        private bool stopFlag = false;

        public ProgressFormGoogleDownloaderKeyword(Main _parentForm, int _imageCount)
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();

            parentForm = _parentForm;
            imageCount = _imageCount;
            reqGoogle = new RequestGoogleKeyword(parentForm);

            CheckForIllegalCrossThreadCalls = false;
        }

        public void downloadStart()
        {
            log.Debug("downloadStart()");
            // 이미지 다운로드 시작

            // 키워드 검색
            List<String> downList = null;
            string savePath;
            for (int index = 0; index < parentForm.kryptonListBoxKeyword.Items.Count; index++)
            {
                parentForm.kryptonListBoxImgDownloadURL.Items.Clear();
                //listViewKeyword.SelectedItems = index;
                parentForm.kryptonListBoxKeyword.SelectedIndex = index;
                downList = reqGoogle.getImageUrlList(parentForm.kryptonListBoxKeyword.Items[parentForm.kryptonListBoxKeyword.SelectedIndex].ToString(), imageCount);

                foreach (string text in downList)
                {
                    parentForm.kryptonListBoxImgDownloadURL.Items.Add(text);
                }

                parentForm.kryptonListBoxImgDownloadURL.Refresh();

                // 이미지 다운로드 시작.

                savePath = makeSaveDir();
                //reqGoogle.getDownloadImage(listBoxImgDownloadURL, savePath);

                int saveFileCount = 0;
                bool success = false;
                string fileName = null;
                for (int imgIndex = 0; imgIndex < parentForm.kryptonListBoxImgDownloadURL.Items.Count; imgIndex++)
                {
                    if (stopFlag)
                        break;

                    //saveFileIndex = imgIndex;
                    fileName = savePath + "\\" + getRandomNum();
                    parentForm.kryptonListBoxImgDownloadURL.SelectedIndex = imgIndex;
                    success = reqGoogle.getDownloadImage(parentForm.kryptonListBoxImgDownloadURL.SelectedItem.ToString(), fileName);
                    if (success)
                    {
                        // 파일 받았으면.
                        saveFileCount++;
                    }

                    //log.DebugLine("saveFileICount: " + saveFileCount);
                    if (saveFileCount == imageCount)
                        break;
                }

                var keyword = parentForm.kryptonListBoxKeyword.SelectedItem.ToString();
                var requestCount = parentForm.kryptonTextBoxImageCountKey.Text;
                var msg = string.Format("{0} - request: {1}, saved: {2}", keyword, requestCount, saveFileCount);
                parentForm.kryptonListBoxKeyword.Items[parentForm.kryptonListBoxKeyword.SelectedIndex] = msg;
            }
            //this.Enabled = true;  
            parentForm.kryptonListBoxImgDownloadURL.Items.Clear();
            this.Close();
        }

        public string makeSaveDir()
        {
            // 저장위치 경로.
            string val = parentForm.kryptonTextBoxSavePath.Text + "\\" + parentForm.kryptonListBoxKeyword.SelectedItem.ToString();// + "_" + parentForm.kryptonComboBoxSize.Text;

            if (parentForm.kryptonComboBoxSize.SelectedIndex > 0)
            {
                val += "_" + parentForm.kryptonComboBoxSize.Text;
            }

            //+ "_" +   parentForm.kryptonComboBoxColor.SelectedItem.ToString() + "_" + parentForm.kryptonComboBoxSize.SelectedItem.ToString();
            val = val.Replace(" ", "_");
            if (!Directory.Exists(@val))
                Directory.CreateDirectory(@val);
            return val;
        }

        private void ProgressFormGoogleDownloaderKeyword_Load(object sender, EventArgs e)
        {
            log.Debug("ProgressFormGoogleDownloaderKeyword_Load");

            Thread t1 = new Thread(new ThreadStart(downloadStart));
            t1.Start();

            //downloadStart();
        }

        private void kryptonButtonStop_Click(object sender, EventArgs e)
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
