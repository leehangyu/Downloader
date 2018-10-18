using GongSolutions.Shell;
//using google;
using log4net;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        protected static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private ProgressFormGoogleDownloaderFileUpload progressFormGoogleDownloaderFileUpload;
        private ProgressFormGoogleDownloaderKeyword progressFormGoogleDownloaderKeyword;
        private ProgressFormGoogleDownloaderFromURI progressFormGoogleDownloaderFromURI;
        private OpenFileDialog openFileDialog;

        public string downloadPath { get; private set; }

        public Main()
        {
            InitializeComponent();
            log4net.Config.XmlConfigurator.Configure();
            //    toolTip1.SetToolTip(kryptonTextBoxGoogleDownloaderURL, "Image fIle is drop here..."); 
            //reqGoogle = new RequestGoogle(this);        

            //kryptonComboBoxSize.SelectedIndex = 0;
            // kryptonComboBoxColor.SelectedIndex = 0;
        }
        

        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        

        internal void picBoxUploadedUpdate(string uploadFilePath)
        {
            FileStream fs = new FileStream(@uploadFilePath, FileMode.Open);
            pictureBoxUploaded.Image = new Bitmap(fs);
            pictureBoxUploaded.Update();
            fs.Close();

            var uploadedFileName = Path.GetFileNameWithoutExtension(kryptonTextBoxGoogleDownloaderURL.Text); // imgur에 올려진파일명.
            //kryptonTextBoxGoogleDownloaderSavePath.Text = Path.Combine(downloadPath, uploadedFileName); // 저장될 경로 설정.
        }

        internal void setGoogleDownloaderFileLinkUpdate(string link)
        {
            // 이미지 주소.
            kryptonTextBoxGoogleDownloaderURL.Text = link;
        }

        public void picBoxUpdate(string imgFilePath)
        { 
            FileStream fs = new FileStream(@imgFilePath, FileMode.Open);  
            pictureBoxKeywordPreview.Image = new Bitmap(fs);
            pictureBoxKeywordPreview.Update(); 
            fs.Close(); 
        }


        internal void pictureBoxGoogleDownloaderUpdate(string saveFilePath)
        {
            FileStream fs = new FileStream(saveFilePath, FileMode.Open);
            pictureBoxGoogleDownloader.Image = new Bitmap(fs);
           // pictureBoxGoogleDownloader.Load(bmp);
            pictureBoxGoogleDownloader.Update();
            fs.Close();
        }


        private void buttonGoogleDownloaderSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if( fbd.ShowDialog() == DialogResult.OK )
            {
                kryptonTextBoxGoogleDownloaderSavePath.Text = fbd.SelectedPath;
            }
        }


        private bool formValidation()
        {
            if (string.IsNullOrEmpty(kryptonTextBoxCaffePath.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an CaffeLIB Path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (string.IsNullOrEmpty(kryptonTextBoxTargetImagePath.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an Training Images Path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (string.IsNullOrEmpty(kryptonTextBoxCategoryName.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an Category Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (string.IsNullOrEmpty(kryptonTextBoxResizeWidth.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an resize width.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (Regex.IsMatch(kryptonTextBoxResizeWidth.Text, "[^0-9]"))
            {
                MessageBox.Show(this.ParentForm, "You must specify an resize width, Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (string.IsNullOrEmpty(kryptonTextBoxResizeHeight.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an resize height.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (Regex.IsMatch(kryptonTextBoxResizeHeight.Text, "[^0-9]"))
            {
                MessageBox.Show(this.ParentForm, "You must specify an resize height, Please enter only numbers.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (kryptonCheckBoxEncodeType.Checked)
            {
                if (string.IsNullOrEmpty(kryptonTextBoxEncodeType.Text))
                {
                    MessageBox.Show(this.ParentForm, "You must specify an encode type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return false;
                }
            }

            if (string.IsNullOrEmpty(kryptonTextBoxDBSavePath.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an DB Path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }

            if (string.IsNullOrEmpty(kryptonTextBoxDBName.Text))
            {
                MessageBox.Show(this.ParentForm, "You must specify an DB Name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return false;
            }


            return true;
        }

        private void kryptonButtonTargetImagePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kryptonTextBoxTargetImagePath.Text = fbd.SelectedPath;
            }
        }

        private void kryptonButtonDBSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kryptonTextBoxDBSavePath.Text = fbd.SelectedPath;
            }
        }

        private void kryptonButtonConvertDBRun_Click(object sender, EventArgs e)
        {
            //Debug Output: /K C:\caffe-bin\convert-imageset.exe -backend=leveldb C:\Download\ C:\Users\kpst-k\AppData\Local\Temp\tmp7E69.tmp c:\export Process ImageSave.exe (4952)
            if (formValidation())
            {
                // make temp file
                string tempfileTrain = Path.GetTempFileName();
                string tempLabel = Path.GetTempFileName();

                string caffeLibPath = kryptonTextBoxCaffePath.Text;
                string trainingImagePath = kryptonTextBoxTargetImagePath.Text;
                string categoryName = kryptonTextBoxCategoryName.Text;
                string resizeWidth = kryptonTextBoxResizeWidth.Text;
                string resizeHeight = kryptonTextBoxResizeHeight.Text;
                string encodeType = kryptonTextBoxEncodeType.Text;
                string grayChecked = kryptonCheckBoxGray.Checked.ToString().ToLower();
                string shuffleChecked = kryptonCheckBoxShuffle.Checked.ToString().ToLower();
                string checkSizeChecked = kryptonCheckBoxCheckSize.Checked.ToString().ToLower();
                string encodeChecked = kryptonCheckBoxEncode.Checked.ToString().ToLower();
                bool encodeTypeChecked = kryptonCheckBoxEncodeType.Checked;
                string dbName = kryptonTextBoxDBName.Text;
                string exportPath = kryptonTextBoxDBSavePath.Text + "\\" + categoryName;
                 
                // directory create.
                if (Directory.Exists(exportPath))
                    Directory.Delete(exportPath, true);
                Directory.CreateDirectory(exportPath);
                // end.

                // write tempfile for label.txt 
                var dirs = Directory.GetDirectories(@trainingImagePath);
                if (dirs.Length == 0)
                {
                    MessageBox.Show(this.ParentForm, "folder path error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                    return;
                }

                for (int index = 0; index < dirs.Length; index++)
                {
                    dirs[index] = dirs[index].Replace(@trainingImagePath + "\\", "");
                }
                File.AppendAllLines(tempLabel, dirs);
                File.Copy(tempLabel, exportPath + "\\labels.txt", true);
                // end.


                // write tempfile for train.txt 
                string[] filePaths = Directory.GetFiles(@trainingImagePath, "*.*", SearchOption.AllDirectories).Where(s => s.EndsWith(".jpg") || s.EndsWith(".bmp") || s.EndsWith(".png")).ToArray();
                string[] tempDirs = Directory.GetDirectories(@trainingImagePath);
                for (int index = 0; index < tempDirs.Length; index++)
                {
                    for (int tempIndex = 0; tempIndex < filePaths.Length; tempIndex++)
                    {
                        if (filePaths[tempIndex].Contains(tempDirs[index]))
                        {
                            filePaths[tempIndex] = filePaths[tempIndex] + " " + index; 
                        } 
                    }
                }
                File.AppendAllLines(tempfileTrain, filePaths);
                File.Copy(tempfileTrain, exportPath + "\\train.txt", true);
                // end.


                string execute = String.Format("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}",
                    caffeLibPath,
                    "convert none",
                    exportPath + "\\train.txt",
                    exportPath + "\\" + "train", //  + ".db",//+ dbName + ".db",
                    (kryptonRadioButtonLmdb.Checked ? "lmdb" : "leveldb"),
                    resizeWidth,
                    resizeHeight,
                    grayChecked,
                    shuffleChecked,
                    checkSizeChecked,
                    encodeChecked,
                    encodeTypeChecked ? encodeType : "none",
                    "log"
                     );

                log.Debug("execute: " + execute); 

                Process cmd = new Process();
                cmd.StartInfo.FileName = @"cmd.exe";
                cmd.StartInfo.Arguments = @"/K " + execute;  // <-- This will execute the command and wait to close
                cmd.Start();
                cmd.WaitForExit();

            }
        }

        private void kryptonButtonCaffeLibPathSet_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "Text files (*.txt)|*.txt";
            openFileDialog.Filter = "DeepSDK_Caffe.exe|DeepSDK_Caffe.exe";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kryptonTextBoxCaffePath.Text = openFileDialog.FileName;
            }
        }

        private void kryptonButtonKeywordOpen_Click(object sender, EventArgs e)
        {
            // 키워드 파일 열기
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                kryptonTextBoxKeywordFile.Text = openFileDialog.FileName;

                //log.Debug(openFileDialog.FileName);
                if (File.Exists(kryptonTextBoxKeywordFile.Text))
                {
                    kryptonListBoxKeyword.Items.Clear();

                    string[] lines = File.ReadAllLines(kryptonTextBoxKeywordFile.Text, Encoding.Default);
                    foreach (String text in lines)
                    {
                        //log.Debug(text);
                        if (text.Length > 0)
                        {
                            kryptonListBoxKeyword.Items.Add(text);
                        }
                    }
                    kryptonListBoxKeyword.Refresh();
                }
            }
            openFileDialog.Dispose();
        }

        private void kryptonButtonImageSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
                kryptonTextBoxSavePath.Text = fbd.SelectedPath;
        }

        private void kryptonButtonDownloadStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(kryptonTextBoxKeywordFile.Text))
            {
                MessageBox.Show(this, "You must specify an Keyword file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(kryptonTextBoxSavePath.Text))
            {
                MessageBox.Show(this, "You must specify an Download path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (File.Exists(kryptonTextBoxKeywordFile.Text))
            {
                kryptonListBoxKeyword.Items.Clear();

                string[] lines = File.ReadAllLines(kryptonTextBoxKeywordFile.Text, Encoding.Default);
                foreach (String text in lines)
                {
                    //log.Debug(text);
                    if (text.Length > 0)
                    {
                        kryptonListBoxKeyword.Items.Add(text);
                    }
                }
                kryptonListBoxKeyword.Refresh();
            }

            int imageCount = Int32.Parse(kryptonTextBoxImageCountKey.Text); 
            if(imageCount<10 || imageCount>1200 )
            {
                MessageBox.Show(this, "wrong download images (min:10, max:1200)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (kryptonListBoxKeyword.Items.Count > 0)
            {
                progressFormGoogleDownloaderKeyword = new ProgressFormGoogleDownloaderKeyword(this, imageCount);

                try
                {
                    progressFormGoogleDownloaderKeyword.ShowDialog();
                }
                catch (Exception ex)
                {
                    log.Debug(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(this, "You must specify an Keyword file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kryptonButtonOpenGoogleDownloaderFile_Click(object sender, EventArgs e)
        {
            // 이미지 검색 파일 열기 
            openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JPEG (*.JPG,*.JPEG,*.JPE)|*.jpg;*.jpeg;*.jpe|PNG (*.PNG)|*.png";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //textBoxGoogleDownloader.Text = openFileDialog.FileName;
                try
                {
                    progressFormGoogleDownloaderFileUpload = new ProgressFormGoogleDownloaderFileUpload(this, openFileDialog.FileName);
                    progressFormGoogleDownloaderFileUpload.ShowDialog();
                    progressFormGoogleDownloaderFileUpload.Dispose();
                }
                catch (Exception ex)
                {
                    log.Debug(ex.ToString());
                }
            }
        }


        private void kryptonButtonGoogleDownloaderSavePath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                kryptonTextBoxGoogleDownloaderSavePath.Text = fbd.SelectedPath;
                downloadPath = fbd.SelectedPath;

                if (kryptonTextBoxGoogleDownloaderURL.Text.Contains("http://i.imgur.com"))
                {
                    var uploadedFileName = Path.GetFileNameWithoutExtension(kryptonTextBoxGoogleDownloaderURL.Text); // imgur에 올려진파일명.
                    kryptonTextBoxGoogleDownloaderSavePath.Text = Path.Combine(downloadPath, uploadedFileName); // 저장될 경로 설정.
                } 
            }
        }

        private void kryptonButtonGoogleDownloaderStart_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(kryptonTextBoxGoogleDownloaderURL.Text))
            {
                MessageBox.Show(this, "You must specify an Upload image path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(kryptonTextBoxGoogleDownloaderSavePath.Text))
            {
                MessageBox.Show(this, "You must specify an Download path.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 

            int imageCount = Int32.Parse(kryptonTextBoxImageCountURL.Text);
            if (imageCount < 10 || imageCount > 1200)
            {
                MessageBox.Show(this, "wrong download images (min:10, max:1200)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // 이미지 검색
            kryptonListBoxGoogleDownloader.ListBox.Items.Clear();
            if (kryptonTextBoxGoogleDownloaderURL.Text.Length > 0)
            {
                try
                {
                    progressFormGoogleDownloaderFromURI = new ProgressFormGoogleDownloaderFromURI(this, new Uri(kryptonTextBoxGoogleDownloaderURL.Text), imageCount);
                    progressFormGoogleDownloaderFromURI.StartPosition = FormStartPosition.CenterParent;
                    progressFormGoogleDownloaderFromURI.ShowDialog();
                    progressFormGoogleDownloaderFromURI.Dispose();
                }
                catch (UriFormatException ex1)
                {
                    log.Debug(ex1.ToString());
                    MessageBox.Show(this, "image file empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    log.Debug(ex.ToString());
                }
            }
        } 

        private void kryptonTextImageCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kryptonTextBoxImageCountURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void kryptonTextBoxGoogleDownloaderURL_DragEnter(object sender, DragEventArgs e)
        {
            log.Debug("DragEnter");
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy | DragDropEffects.Scroll;
            }
        }

        private void kryptonTextBoxGoogleDownloaderURL_DragDrop(object sender, DragEventArgs e)
        {
            log.Debug("DragDrop");
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                try
                {
                    string[] file = (string[])e.Data.GetData(DataFormats.FileDrop);
                    
                    if(!imageFileCheck(file[0]))
                    {
                        MessageBox.Show(this, "no image file!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    else
                    {
                        kryptonTextBoxGoogleDownloaderURL.Text = file[0];
                        progressFormGoogleDownloaderFileUpload = new ProgressFormGoogleDownloaderFileUpload(this, kryptonTextBoxGoogleDownloaderURL.Text);
                        //progressFormGoogleDownloaderFileUpload.Parent = this;
                        //progressFormGoogleDownloaderFileUpload.StartPosition = FormStartPosition.Manual;

                        progressFormGoogleDownloaderFileUpload.Size = new Size(521, 73);

                        progressFormGoogleDownloaderFileUpload.StartPosition = FormStartPosition.Manual;
                        progressFormGoogleDownloaderFileUpload.Location = new Point(
                          this.Location.X + (this.Width - progressFormGoogleDownloaderFileUpload.Width) / 2,
                          this.Location.Y + (this.Height - progressFormGoogleDownloaderFileUpload.Height) / 2
                        );

                        progressFormGoogleDownloaderFileUpload.ShowDialog();
                        progressFormGoogleDownloaderFileUpload.Dispose();
                    }
                }
                catch (Exception ex)
                {
                    log.Debug(ex.ToString());
                }
            }
        }

        private bool imageFileCheck(string filePath)
        {
            byte[] data = File.ReadAllBytes(filePath);

            if (data[0] == (char)0xff && data[1] == (char)0xd8)
            {
                return true;    // jpg
            }
            else if (data[0] == (char)0x89 && data[1] == (char)0x50)
            {
                return true;    // png
            }

            return false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            downloadPath = kryptonTextBoxGoogleDownloaderSavePath.Text;
        }

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
