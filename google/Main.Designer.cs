using System;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            try
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            } catch (Exception e)
            {
                Debug.WriteLine(e.ToString());
            }
            
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.pictureBoxUploaded = new System.Windows.Forms.PictureBox();
            this.pictureBoxGoogleDownloader = new System.Windows.Forms.PictureBox();
            this.pictureBoxKeywordPreview = new System.Windows.Forms.PictureBox();
            this.kryptonNavigator1 = new ComponentFactory.Krypton.Navigator.KryptonNavigator();
            this.kryptonPage3 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonGroupBox5 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox4 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonListBoxKeyword = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonGroupBox3 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonListBoxImgDownloadURL = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonGroupBox2 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel13 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonKeywordOpen = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxKeywordFile = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonDownloadStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxSavePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonImageSavePath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonLabel16 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel19 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxImageCountKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel14 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonPage4 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonGroupBox6 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.kryptonLabel17 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel18 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxGoogleDownloaderURL = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxGoogleDownloaderSavePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonOpenGoogleDownloaderFile = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonGoogleDownloaderSavePath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonGoogleDownloaderStart = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxImageCountURL = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel20 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox7 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonListBoxGoogleDownloader = new ComponentFactory.Krypton.Toolkit.KryptonListBox();
            this.kryptonGroupBox8 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonGroupBox9 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonPage2 = new ComponentFactory.Krypton.Navigator.KryptonPage();
            this.panelConvertDB = new System.Windows.Forms.Panel();
            this.kryptonLabel23 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxEncodeType = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel22 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonCheckBoxEncodeType = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel21 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonButtonConvertDBRun = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxDBSavePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonDBSavePath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonTextBoxDBName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel8 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel12 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonGroupBox1 = new ComponentFactory.Krypton.Toolkit.KryptonGroupBox();
            this.kryptonCheckBoxEncode = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBoxCheckSize = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBoxShuffle = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonCheckBoxGray = new ComponentFactory.Krypton.Toolkit.KryptonCheckBox();
            this.kryptonLabel9 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel10 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel11 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel6 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel7 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel5 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxResizeHeight = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxResizeWidth = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonRadioButtonLevelDb = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonRadioButtonLmdb = new ComponentFactory.Krypton.Toolkit.KryptonRadioButton();
            this.kryptonTextBoxCategoryName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel1 = new ComponentFactory.Krypton.Toolkit.KryptonLabel();
            this.kryptonTextBoxTargetImagePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonTextBoxCaffePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kryptonButtonTargetImagePath = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonButtonCaffeLibPathSet = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.kryptonSplitContainer1 = new ComponentFactory.Krypton.Toolkit.KryptonSplitContainer();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.kryptonComboBoxSize = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploaded)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogleDownloader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeywordPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).BeginInit();
            this.kryptonNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).BeginInit();
            this.kryptonPage3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5.Panel)).BeginInit();
            this.kryptonGroupBox5.Panel.SuspendLayout();
            this.kryptonGroupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).BeginInit();
            this.kryptonGroupBox4.Panel.SuspendLayout();
            this.kryptonGroupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).BeginInit();
            this.kryptonGroupBox3.Panel.SuspendLayout();
            this.kryptonGroupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).BeginInit();
            this.kryptonGroupBox2.Panel.SuspendLayout();
            this.kryptonGroupBox2.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).BeginInit();
            this.kryptonPage4.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6.Panel)).BeginInit();
            this.kryptonGroupBox6.Panel.SuspendLayout();
            this.kryptonGroupBox6.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox7.Panel)).BeginInit();
            this.kryptonGroupBox7.Panel.SuspendLayout();
            this.kryptonGroupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox8.Panel)).BeginInit();
            this.kryptonGroupBox8.Panel.SuspendLayout();
            this.kryptonGroupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox9.Panel)).BeginInit();
            this.kryptonGroupBox9.Panel.SuspendLayout();
            this.kryptonGroupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).BeginInit();
            this.kryptonPage2.SuspendLayout();
            this.panelConvertDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).BeginInit();
            this.kryptonSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxSize)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxUploaded
            // 
            this.pictureBoxUploaded.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxUploaded.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxUploaded.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxUploaded.Name = "pictureBoxUploaded";
            this.pictureBoxUploaded.Size = new System.Drawing.Size(379, 279);
            this.pictureBoxUploaded.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxUploaded.TabIndex = 8;
            this.pictureBoxUploaded.TabStop = false;
            // 
            // pictureBoxGoogleDownloader
            // 
            this.pictureBoxGoogleDownloader.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxGoogleDownloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxGoogleDownloader.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxGoogleDownloader.Name = "pictureBoxGoogleDownloader";
            this.pictureBoxGoogleDownloader.Size = new System.Drawing.Size(379, 279);
            this.pictureBoxGoogleDownloader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGoogleDownloader.TabIndex = 3;
            this.pictureBoxGoogleDownloader.TabStop = false;
            // 
            // pictureBoxKeywordPreview
            // 
            this.pictureBoxKeywordPreview.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBoxKeywordPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxKeywordPreview.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxKeywordPreview.Name = "pictureBoxKeywordPreview";
            this.pictureBoxKeywordPreview.Size = new System.Drawing.Size(378, 278);
            this.pictureBoxKeywordPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxKeywordPreview.TabIndex = 3;
            this.pictureBoxKeywordPreview.TabStop = false;
            // 
            // kryptonNavigator1
            // 
            this.kryptonNavigator1.Button.ButtonDisplayLogic = ComponentFactory.Krypton.Navigator.ButtonDisplayLogic.None;
            this.kryptonNavigator1.Button.CloseButtonDisplay = ComponentFactory.Krypton.Navigator.ButtonDisplay.Hide;
            this.kryptonNavigator1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonNavigator1.Location = new System.Drawing.Point(0, 0);
            this.kryptonNavigator1.Name = "kryptonNavigator1";
            this.kryptonNavigator1.Pages.AddRange(new ComponentFactory.Krypton.Navigator.KryptonPage[] {
            this.kryptonPage3,
            this.kryptonPage4,
            this.kryptonPage2});
            this.kryptonNavigator1.SelectedIndex = 0;
            this.kryptonNavigator1.Size = new System.Drawing.Size(780, 515);
            this.kryptonNavigator1.TabIndex = 0;
            this.kryptonNavigator1.Text = "kryptonNavigator1";
            // 
            // kryptonPage3
            // 
            this.kryptonPage3.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage3.Controls.Add(this.tableLayoutPanel5);
            this.kryptonPage3.Flags = 65534;
            this.kryptonPage3.LastVisibleSet = true;
            this.kryptonPage3.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage3.Name = "kryptonPage3";
            this.kryptonPage3.Size = new System.Drawing.Size(778, 488);
            this.kryptonPage3.Text = "Search by keyword";
            this.kryptonPage3.ToolTipTitle = "Page ToolTip";
            this.kryptonPage3.UniqueName = "5FB0DFFE16E04405259076F61DB2B8C3";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.12854F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.87146F));
            this.tableLayoutPanel5.Controls.Add(this.kryptonGroupBox5, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.kryptonGroupBox4, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.kryptonGroupBox3, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.kryptonGroupBox2, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.88525F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.11475F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(778, 488);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // kryptonGroupBox5
            // 
            this.kryptonGroupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox5.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox5.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox5.Location = new System.Drawing.Point(393, 183);
            this.kryptonGroupBox5.Name = "kryptonGroupBox5";
            // 
            // kryptonGroupBox5.Panel
            // 
            this.kryptonGroupBox5.Panel.Controls.Add(this.pictureBoxKeywordPreview);
            this.kryptonGroupBox5.Size = new System.Drawing.Size(382, 302);
            this.kryptonGroupBox5.TabIndex = 3;
            this.kryptonGroupBox5.Values.Heading = "Preview";
            // 
            // kryptonGroupBox4
            // 
            this.kryptonGroupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox4.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox4.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox4.Location = new System.Drawing.Point(3, 183);
            this.kryptonGroupBox4.Name = "kryptonGroupBox4";
            // 
            // kryptonGroupBox4.Panel
            // 
            this.kryptonGroupBox4.Panel.Controls.Add(this.kryptonListBoxKeyword);
            this.kryptonGroupBox4.Size = new System.Drawing.Size(384, 302);
            this.kryptonGroupBox4.TabIndex = 2;
            this.kryptonGroupBox4.Values.Heading = "Keyword";
            // 
            // kryptonListBoxKeyword
            // 
            this.kryptonListBoxKeyword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonListBoxKeyword.Location = new System.Drawing.Point(0, 0);
            this.kryptonListBoxKeyword.Name = "kryptonListBoxKeyword";
            this.kryptonListBoxKeyword.Size = new System.Drawing.Size(380, 278);
            this.kryptonListBoxKeyword.TabIndex = 8;
            // 
            // kryptonGroupBox3
            // 
            this.kryptonGroupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox3.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox3.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox3.Location = new System.Drawing.Point(393, 3);
            this.kryptonGroupBox3.Name = "kryptonGroupBox3";
            // 
            // kryptonGroupBox3.Panel
            // 
            this.kryptonGroupBox3.Panel.Controls.Add(this.kryptonListBoxImgDownloadURL);
            this.kryptonGroupBox3.Size = new System.Drawing.Size(382, 174);
            this.kryptonGroupBox3.TabIndex = 1;
            this.kryptonGroupBox3.Values.Heading = "Download url";
            // 
            // kryptonListBoxImgDownloadURL
            // 
            this.kryptonListBoxImgDownloadURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonListBoxImgDownloadURL.Enabled = false;
            this.kryptonListBoxImgDownloadURL.Location = new System.Drawing.Point(0, 0);
            this.kryptonListBoxImgDownloadURL.Name = "kryptonListBoxImgDownloadURL";
            this.kryptonListBoxImgDownloadURL.Size = new System.Drawing.Size(378, 150);
            this.kryptonListBoxImgDownloadURL.TabIndex = 9;
            // 
            // kryptonGroupBox2
            // 
            this.kryptonGroupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox2.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox2.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox2.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox2.Name = "kryptonGroupBox2";
            // 
            // kryptonGroupBox2.Panel
            // 
            this.kryptonGroupBox2.Panel.Controls.Add(this.tableLayoutPanel6);
            this.kryptonGroupBox2.Size = new System.Drawing.Size(384, 174);
            this.kryptonGroupBox2.TabIndex = 0;
            this.kryptonGroupBox2.Values.Heading = "Search by keyword";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26.84211F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.8421F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.31579F));
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel13, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.kryptonButtonKeywordOpen, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.kryptonTextBoxKeywordFile, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.kryptonButtonDownloadStart, 0, 4);
            this.tableLayoutPanel6.Controls.Add(this.kryptonTextBoxSavePath, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.kryptonButtonImageSavePath, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel16, 0, 1);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel19, 0, 2);
            this.tableLayoutPanel6.Controls.Add(this.kryptonTextBoxImageCountKey, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.kryptonLabel14, 0, 3);
            this.tableLayoutPanel6.Controls.Add(this.kryptonComboBoxSize, 1, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(380, 150);
            this.tableLayoutPanel6.TabIndex = 0;
            this.tableLayoutPanel6.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel6_Paint);
            // 
            // kryptonLabel13
            // 
            this.kryptonLabel13.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel13.Location = new System.Drawing.Point(21, 5);
            this.kryptonLabel13.Name = "kryptonLabel13";
            this.kryptonLabel13.Size = new System.Drawing.Size(78, 20);
            this.kryptonLabel13.TabIndex = 0;
            this.kryptonLabel13.Values.Text = "Keyword file";
            // 
            // kryptonButtonKeywordOpen
            // 
            this.kryptonButtonKeywordOpen.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonKeywordOpen.Location = new System.Drawing.Point(304, 3);
            this.kryptonButtonKeywordOpen.Name = "kryptonButtonKeywordOpen";
            this.kryptonButtonKeywordOpen.Size = new System.Drawing.Size(73, 24);
            this.kryptonButtonKeywordOpen.TabIndex = 2;
            this.kryptonButtonKeywordOpen.Values.Text = "select";
            this.kryptonButtonKeywordOpen.Click += new System.EventHandler(this.kryptonButtonKeywordOpen_Click);
            // 
            // kryptonTextBoxKeywordFile
            // 
            this.kryptonTextBoxKeywordFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxKeywordFile.Location = new System.Drawing.Point(105, 3);
            this.kryptonTextBoxKeywordFile.Name = "kryptonTextBoxKeywordFile";
            this.kryptonTextBoxKeywordFile.ReadOnly = true;
            this.kryptonTextBoxKeywordFile.Size = new System.Drawing.Size(190, 23);
            this.kryptonTextBoxKeywordFile.TabIndex = 1;
            // 
            // kryptonButtonDownloadStart
            // 
            this.tableLayoutPanel6.SetColumnSpan(this.kryptonButtonDownloadStart, 3);
            this.kryptonButtonDownloadStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonDownloadStart.Location = new System.Drawing.Point(304, 123);
            this.kryptonButtonDownloadStart.Name = "kryptonButtonDownloadStart";
            this.kryptonButtonDownloadStart.Size = new System.Drawing.Size(73, 24);
            this.kryptonButtonDownloadStart.TabIndex = 7;
            this.kryptonButtonDownloadStart.Values.Text = "Download";
            this.kryptonButtonDownloadStart.Click += new System.EventHandler(this.kryptonButtonDownloadStart_Click);
            // 
            // kryptonTextBoxSavePath
            // 
            this.kryptonTextBoxSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxSavePath.Location = new System.Drawing.Point(105, 33);
            this.kryptonTextBoxSavePath.Name = "kryptonTextBoxSavePath";
            this.kryptonTextBoxSavePath.ReadOnly = true;
            this.kryptonTextBoxSavePath.Size = new System.Drawing.Size(190, 23);
            this.kryptonTextBoxSavePath.TabIndex = 5;
            // 
            // kryptonButtonImageSavePath
            // 
            this.kryptonButtonImageSavePath.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonImageSavePath.Location = new System.Drawing.Point(304, 33);
            this.kryptonButtonImageSavePath.Name = "kryptonButtonImageSavePath";
            this.kryptonButtonImageSavePath.Size = new System.Drawing.Size(73, 24);
            this.kryptonButtonImageSavePath.TabIndex = 6;
            this.kryptonButtonImageSavePath.Values.Text = "select";
            this.kryptonButtonImageSavePath.Click += new System.EventHandler(this.kryptonButtonImageSavePath_Click);
            // 
            // kryptonLabel16
            // 
            this.kryptonLabel16.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel16.Location = new System.Drawing.Point(5, 35);
            this.kryptonLabel16.Name = "kryptonLabel16";
            this.kryptonLabel16.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel16.TabIndex = 3;
            this.kryptonLabel16.Values.Text = "Download path";
            // 
            // kryptonLabel19
            // 
            this.kryptonLabel19.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel19.Location = new System.Drawing.Point(8, 65);
            this.kryptonLabel19.Name = "kryptonLabel19";
            this.kryptonLabel19.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel19.TabIndex = 8;
            this.kryptonLabel19.Values.Text = "Download files";
            // 
            // kryptonTextBoxImageCountKey
            // 
            this.kryptonTextBoxImageCountKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxImageCountKey.Location = new System.Drawing.Point(105, 63);
            this.kryptonTextBoxImageCountKey.Name = "kryptonTextBoxImageCountKey";
            this.kryptonTextBoxImageCountKey.Size = new System.Drawing.Size(190, 23);
            this.kryptonTextBoxImageCountKey.TabIndex = 9;
            this.kryptonTextBoxImageCountKey.Text = "100";
            this.kryptonTextBoxImageCountKey.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kryptonTextImageCount_KeyPress);
            // 
            // kryptonLabel14
            // 
            this.kryptonLabel14.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel14.Location = new System.Drawing.Point(30, 95);
            this.kryptonLabel14.Name = "kryptonLabel14";
            this.kryptonLabel14.Size = new System.Drawing.Size(69, 20);
            this.kryptonLabel14.TabIndex = 10;
            this.kryptonLabel14.Values.Text = "Image Size";
            // 
            // kryptonPage4
            // 
            this.kryptonPage4.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage4.Controls.Add(this.tableLayoutPanel1);
            this.kryptonPage4.Flags = 65534;
            this.kryptonPage4.LastVisibleSet = true;
            this.kryptonPage4.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage4.Name = "kryptonPage4";
            this.kryptonPage4.Size = new System.Drawing.Size(778, 488);
            this.kryptonPage4.Text = "Search by image";
            this.kryptonPage4.ToolTipTitle = "Page ToolTip";
            this.kryptonPage4.UniqueName = "AD78A24F8EB94ED3C69289396D2FD136";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroupBox6, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroupBox7, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroupBox8, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.kryptonGroupBox9, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.68033F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.31967F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(778, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // kryptonGroupBox6
            // 
            this.kryptonGroupBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox6.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox6.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox6.Location = new System.Drawing.Point(3, 3);
            this.kryptonGroupBox6.Name = "kryptonGroupBox6";
            // 
            // kryptonGroupBox6.Panel
            // 
            this.kryptonGroupBox6.Panel.Controls.Add(this.tableLayoutPanel4);
            this.kryptonGroupBox6.Size = new System.Drawing.Size(383, 173);
            this.kryptonGroupBox6.TabIndex = 0;
            this.kryptonGroupBox6.Values.Heading = "Search by image";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.81625F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.14825F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.03551F));
            this.tableLayoutPanel4.Controls.Add(this.kryptonLabel17, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.kryptonLabel18, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.kryptonTextBoxGoogleDownloaderURL, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.kryptonTextBoxGoogleDownloaderSavePath, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.kryptonButtonOpenGoogleDownloaderFile, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.kryptonButtonGoogleDownloaderSavePath, 2, 1);
            this.tableLayoutPanel4.Controls.Add(this.kryptonButtonGoogleDownloaderStart, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.kryptonTextBoxImageCountURL, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.kryptonLabel20, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 5;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(379, 149);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // kryptonLabel17
            // 
            this.kryptonLabel17.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel17.Location = new System.Drawing.Point(15, 5);
            this.kryptonLabel17.Name = "kryptonLabel17";
            this.kryptonLabel17.Size = new System.Drawing.Size(87, 20);
            this.kryptonLabel17.TabIndex = 0;
            this.kryptonLabel17.Values.Text = "Upload image";
            // 
            // kryptonLabel18
            // 
            this.kryptonLabel18.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel18.Location = new System.Drawing.Point(8, 35);
            this.kryptonLabel18.Name = "kryptonLabel18";
            this.kryptonLabel18.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel18.TabIndex = 1;
            this.kryptonLabel18.Values.Text = "Download path";
            // 
            // kryptonTextBoxGoogleDownloaderURL
            // 
            this.kryptonTextBoxGoogleDownloaderURL.AllowDrop = true;
            this.kryptonTextBoxGoogleDownloaderURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxGoogleDownloaderURL.Location = new System.Drawing.Point(108, 3);
            this.kryptonTextBoxGoogleDownloaderURL.Name = "kryptonTextBoxGoogleDownloaderURL";
            this.kryptonTextBoxGoogleDownloaderURL.ReadOnly = true;
            this.kryptonTextBoxGoogleDownloaderURL.Size = new System.Drawing.Size(187, 23);
            this.kryptonTextBoxGoogleDownloaderURL.TabIndex = 1;
            this.toolTip1.SetToolTip(this.kryptonTextBoxGoogleDownloaderURL, "Image fIle is drop here...");
            this.kryptonTextBoxGoogleDownloaderURL.DragDrop += new System.Windows.Forms.DragEventHandler(this.kryptonTextBoxGoogleDownloaderURL_DragDrop);
            this.kryptonTextBoxGoogleDownloaderURL.DragEnter += new System.Windows.Forms.DragEventHandler(this.kryptonTextBoxGoogleDownloaderURL_DragEnter);
            // 
            // kryptonTextBoxGoogleDownloaderSavePath
            // 
            this.kryptonTextBoxGoogleDownloaderSavePath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxGoogleDownloaderSavePath.Location = new System.Drawing.Point(108, 33);
            this.kryptonTextBoxGoogleDownloaderSavePath.Name = "kryptonTextBoxGoogleDownloaderSavePath";
            this.kryptonTextBoxGoogleDownloaderSavePath.ReadOnly = true;
            this.kryptonTextBoxGoogleDownloaderSavePath.Size = new System.Drawing.Size(187, 23);
            this.kryptonTextBoxGoogleDownloaderSavePath.TabIndex = 3;
            // 
            // kryptonButtonOpenGoogleDownloaderFile
            // 
            this.kryptonButtonOpenGoogleDownloaderFile.Location = new System.Drawing.Point(301, 3);
            this.kryptonButtonOpenGoogleDownloaderFile.Name = "kryptonButtonOpenGoogleDownloaderFile";
            this.kryptonButtonOpenGoogleDownloaderFile.Size = new System.Drawing.Size(75, 24);
            this.kryptonButtonOpenGoogleDownloaderFile.TabIndex = 2;
            this.kryptonButtonOpenGoogleDownloaderFile.Values.Text = "select";
            this.kryptonButtonOpenGoogleDownloaderFile.Click += new System.EventHandler(this.kryptonButtonOpenGoogleDownloaderFile_Click);
            // 
            // kryptonButtonGoogleDownloaderSavePath
            // 
            this.kryptonButtonGoogleDownloaderSavePath.Location = new System.Drawing.Point(301, 33);
            this.kryptonButtonGoogleDownloaderSavePath.Name = "kryptonButtonGoogleDownloaderSavePath";
            this.kryptonButtonGoogleDownloaderSavePath.Size = new System.Drawing.Size(75, 24);
            this.kryptonButtonGoogleDownloaderSavePath.TabIndex = 4;
            this.kryptonButtonGoogleDownloaderSavePath.Values.Text = "select";
            this.kryptonButtonGoogleDownloaderSavePath.Click += new System.EventHandler(this.kryptonButtonGoogleDownloaderSavePath_Click);
            // 
            // kryptonButtonGoogleDownloaderStart
            // 
            this.tableLayoutPanel4.SetColumnSpan(this.kryptonButtonGoogleDownloaderStart, 3);
            this.kryptonButtonGoogleDownloaderStart.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonGoogleDownloaderStart.Location = new System.Drawing.Point(301, 123);
            this.kryptonButtonGoogleDownloaderStart.Name = "kryptonButtonGoogleDownloaderStart";
            this.kryptonButtonGoogleDownloaderStart.Size = new System.Drawing.Size(75, 24);
            this.kryptonButtonGoogleDownloaderStart.TabIndex = 5;
            this.kryptonButtonGoogleDownloaderStart.Values.Text = "Download";
            this.kryptonButtonGoogleDownloaderStart.Click += new System.EventHandler(this.kryptonButtonGoogleDownloaderStart_Click);
            // 
            // kryptonTextBoxImageCountURL
            // 
            this.kryptonTextBoxImageCountURL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonTextBoxImageCountURL.Location = new System.Drawing.Point(108, 63);
            this.kryptonTextBoxImageCountURL.Name = "kryptonTextBoxImageCountURL";
            this.kryptonTextBoxImageCountURL.Size = new System.Drawing.Size(187, 23);
            this.kryptonTextBoxImageCountURL.TabIndex = 7;
            this.kryptonTextBoxImageCountURL.Text = "100";
            this.kryptonTextBoxImageCountURL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.kryptonTextBoxImageCountURL_KeyPress);
            // 
            // kryptonLabel20
            // 
            this.kryptonLabel20.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.kryptonLabel20.Location = new System.Drawing.Point(11, 65);
            this.kryptonLabel20.Name = "kryptonLabel20";
            this.kryptonLabel20.Size = new System.Drawing.Size(91, 20);
            this.kryptonLabel20.TabIndex = 6;
            this.kryptonLabel20.Values.Text = "Download files";
            // 
            // kryptonGroupBox7
            // 
            this.kryptonGroupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox7.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox7.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox7.Location = new System.Drawing.Point(392, 3);
            this.kryptonGroupBox7.Name = "kryptonGroupBox7";
            // 
            // kryptonGroupBox7.Panel
            // 
            this.kryptonGroupBox7.Panel.Controls.Add(this.kryptonListBoxGoogleDownloader);
            this.kryptonGroupBox7.Size = new System.Drawing.Size(383, 173);
            this.kryptonGroupBox7.TabIndex = 1;
            this.kryptonGroupBox7.Values.Heading = "Download url";
            // 
            // kryptonListBoxGoogleDownloader
            // 
            this.kryptonListBoxGoogleDownloader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonListBoxGoogleDownloader.Enabled = false;
            this.kryptonListBoxGoogleDownloader.Location = new System.Drawing.Point(0, 0);
            this.kryptonListBoxGoogleDownloader.Name = "kryptonListBoxGoogleDownloader";
            this.kryptonListBoxGoogleDownloader.Size = new System.Drawing.Size(379, 149);
            this.kryptonListBoxGoogleDownloader.TabIndex = 6;
            // 
            // kryptonGroupBox8
            // 
            this.kryptonGroupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox8.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox8.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox8.Location = new System.Drawing.Point(3, 182);
            this.kryptonGroupBox8.Name = "kryptonGroupBox8";
            // 
            // kryptonGroupBox8.Panel
            // 
            this.kryptonGroupBox8.Panel.Controls.Add(this.pictureBoxUploaded);
            this.kryptonGroupBox8.Size = new System.Drawing.Size(383, 303);
            this.kryptonGroupBox8.TabIndex = 2;
            this.kryptonGroupBox8.Values.Heading = "Original image";
            // 
            // kryptonGroupBox9
            // 
            this.kryptonGroupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonGroupBox9.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox9.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox9.Location = new System.Drawing.Point(392, 182);
            this.kryptonGroupBox9.Name = "kryptonGroupBox9";
            // 
            // kryptonGroupBox9.Panel
            // 
            this.kryptonGroupBox9.Panel.Controls.Add(this.pictureBoxGoogleDownloader);
            this.kryptonGroupBox9.Size = new System.Drawing.Size(383, 303);
            this.kryptonGroupBox9.TabIndex = 3;
            this.kryptonGroupBox9.Values.Heading = "Preview";
            // 
            // kryptonPage2
            // 
            this.kryptonPage2.AutoHiddenSlideSize = new System.Drawing.Size(200, 200);
            this.kryptonPage2.Controls.Add(this.panelConvertDB);
            this.kryptonPage2.Flags = 65534;
            this.kryptonPage2.LastVisibleSet = true;
            this.kryptonPage2.MinimumSize = new System.Drawing.Size(50, 50);
            this.kryptonPage2.Name = "kryptonPage2";
            this.kryptonPage2.Size = new System.Drawing.Size(778, 488);
            this.kryptonPage2.Text = "Create Image DB";
            this.kryptonPage2.ToolTipTitle = "Page ToolTip";
            this.kryptonPage2.UniqueName = "A46A89A1D3C64CF5BAAD84A2AE0E5FD6";
            // 
            // panelConvertDB
            // 
            this.panelConvertDB.Controls.Add(this.kryptonLabel23);
            this.panelConvertDB.Controls.Add(this.kryptonTextBoxEncodeType);
            this.panelConvertDB.Controls.Add(this.kryptonLabel22);
            this.panelConvertDB.Controls.Add(this.kryptonCheckBoxEncodeType);
            this.panelConvertDB.Controls.Add(this.kryptonLabel21);
            this.panelConvertDB.Controls.Add(this.kryptonButtonConvertDBRun);
            this.panelConvertDB.Controls.Add(this.kryptonTextBoxDBSavePath);
            this.panelConvertDB.Controls.Add(this.kryptonButtonDBSavePath);
            this.panelConvertDB.Controls.Add(this.kryptonTextBoxDBName);
            this.panelConvertDB.Controls.Add(this.kryptonLabel8);
            this.panelConvertDB.Controls.Add(this.kryptonLabel12);
            this.panelConvertDB.Controls.Add(this.kryptonGroupBox1);
            this.panelConvertDB.Controls.Add(this.kryptonTextBoxTargetImagePath);
            this.panelConvertDB.Controls.Add(this.kryptonTextBoxCaffePath);
            this.panelConvertDB.Controls.Add(this.kryptonButtonTargetImagePath);
            this.panelConvertDB.Controls.Add(this.kryptonButtonCaffeLibPathSet);
            this.panelConvertDB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConvertDB.Location = new System.Drawing.Point(0, 0);
            this.panelConvertDB.Name = "panelConvertDB";
            this.panelConvertDB.Size = new System.Drawing.Size(778, 488);
            this.panelConvertDB.TabIndex = 1;
            // 
            // kryptonLabel23
            // 
            this.kryptonLabel23.Location = new System.Drawing.Point(58, 397);
            this.kryptonLabel23.Name = "kryptonLabel23";
            this.kryptonLabel23.Size = new System.Drawing.Size(73, 20);
            this.kryptonLabel23.TabIndex = 40;
            this.kryptonLabel23.Values.Text = "Export Path";
            // 
            // kryptonTextBoxEncodeType
            // 
            this.kryptonTextBoxEncodeType.Location = new System.Drawing.Point(150, 439);
            this.kryptonTextBoxEncodeType.Name = "kryptonTextBoxEncodeType";
            this.kryptonTextBoxEncodeType.Size = new System.Drawing.Size(55, 23);
            this.kryptonTextBoxEncodeType.TabIndex = 15;
            this.kryptonTextBoxEncodeType.Visible = false;
            // 
            // kryptonLabel22
            // 
            this.kryptonLabel22.Location = new System.Drawing.Point(31, 51);
            this.kryptonLabel22.Name = "kryptonLabel22";
            this.kryptonLabel22.Size = new System.Drawing.Size(97, 20);
            this.kryptonLabel22.TabIndex = 39;
            this.kryptonLabel22.Values.Text = "Training Images";
            // 
            // kryptonCheckBoxEncodeType
            // 
            this.kryptonCheckBoxEncodeType.Location = new System.Drawing.Point(51, 439);
            this.kryptonCheckBoxEncodeType.Name = "kryptonCheckBoxEncodeType";
            this.kryptonCheckBoxEncodeType.Size = new System.Drawing.Size(93, 20);
            this.kryptonCheckBoxEncodeType.TabIndex = 14;
            this.kryptonCheckBoxEncodeType.Values.Text = "encode_type";
            this.kryptonCheckBoxEncodeType.Visible = false;
            // 
            // kryptonLabel21
            // 
            this.kryptonLabel21.Location = new System.Drawing.Point(53, 20);
            this.kryptonLabel21.Name = "kryptonLabel21";
            this.kryptonLabel21.Size = new System.Drawing.Size(76, 20);
            this.kryptonLabel21.TabIndex = 16;
            this.kryptonLabel21.Values.Text = "Caffe library";
            // 
            // kryptonButtonConvertDBRun
            // 
            this.kryptonButtonConvertDBRun.Location = new System.Drawing.Point(660, 434);
            this.kryptonButtonConvertDBRun.Name = "kryptonButtonConvertDBRun";
            this.kryptonButtonConvertDBRun.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonConvertDBRun.TabIndex = 19;
            this.kryptonButtonConvertDBRun.Values.Text = "Create DB";
            this.kryptonButtonConvertDBRun.Click += new System.EventHandler(this.kryptonButtonConvertDBRun_Click);
            // 
            // kryptonTextBoxDBSavePath
            // 
            this.kryptonTextBoxDBSavePath.Location = new System.Drawing.Point(135, 397);
            this.kryptonTextBoxDBSavePath.Name = "kryptonTextBoxDBSavePath";
            this.kryptonTextBoxDBSavePath.Size = new System.Drawing.Size(519, 23);
            this.kryptonTextBoxDBSavePath.TabIndex = 18;
            // 
            // kryptonButtonDBSavePath
            // 
            this.kryptonButtonDBSavePath.Location = new System.Drawing.Point(660, 394);
            this.kryptonButtonDBSavePath.Name = "kryptonButtonDBSavePath";
            this.kryptonButtonDBSavePath.Size = new System.Drawing.Size(90, 25);
            this.kryptonButtonDBSavePath.TabIndex = 17;
            this.kryptonButtonDBSavePath.Values.Text = "select";
            this.kryptonButtonDBSavePath.Click += new System.EventHandler(this.kryptonButtonDBSavePath_Click);
            // 
            // kryptonTextBoxDBName
            // 
            this.kryptonTextBoxDBName.Location = new System.Drawing.Point(135, 366);
            this.kryptonTextBoxDBName.Name = "kryptonTextBoxDBName";
            this.kryptonTextBoxDBName.Size = new System.Drawing.Size(615, 23);
            this.kryptonTextBoxDBName.TabIndex = 16;
            // 
            // kryptonLabel8
            // 
            this.kryptonLabel8.Location = new System.Drawing.Point(211, 439);
            this.kryptonLabel8.Name = "kryptonLabel8";
            this.kryptonLabel8.Size = new System.Drawing.Size(363, 20);
            this.kryptonLabel8.TabIndex = 15;
            this.kryptonLabel8.Values.Text = "(Optional) What type should we encode the image (\'png\',\'jpg\',...).";
            this.kryptonLabel8.Visible = false;
            // 
            // kryptonLabel12
            // 
            this.kryptonLabel12.Location = new System.Drawing.Point(70, 366);
            this.kryptonLabel12.Name = "kryptonLabel12";
            this.kryptonLabel12.Size = new System.Drawing.Size(60, 20);
            this.kryptonLabel12.TabIndex = 38;
            this.kryptonLabel12.Values.Text = "DB name";
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.GroupBackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.ControlRibbon;
            this.kryptonGroupBox1.GroupBorderStyle = ComponentFactory.Krypton.Toolkit.PaletteBorderStyle.ControlRibbon;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(24, 82);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBoxEncode);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBoxCheckSize);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBoxShuffle);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonCheckBoxGray);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel9);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel10);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel11);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel6);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel7);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel5);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBoxResizeHeight);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBoxResizeWidth);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel4);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel3);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel2);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonRadioButtonLevelDb);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonRadioButtonLmdb);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonTextBoxCategoryName);
            this.kryptonGroupBox1.Panel.Controls.Add(this.kryptonLabel1);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(726, 268);
            this.kryptonGroupBox1.TabIndex = 37;
            this.kryptonGroupBox1.Values.Heading = "Parameters";
            // 
            // kryptonCheckBoxEncode
            // 
            this.kryptonCheckBoxEncode.Checked = true;
            this.kryptonCheckBoxEncode.CheckState = System.Windows.Forms.CheckState.Checked;
            this.kryptonCheckBoxEncode.Location = new System.Drawing.Point(25, 204);
            this.kryptonCheckBoxEncode.Name = "kryptonCheckBoxEncode";
            this.kryptonCheckBoxEncode.Size = new System.Drawing.Size(64, 20);
            this.kryptonCheckBoxEncode.TabIndex = 13;
            this.kryptonCheckBoxEncode.Values.Text = "encode";
            // 
            // kryptonCheckBoxCheckSize
            // 
            this.kryptonCheckBoxCheckSize.Location = new System.Drawing.Point(25, 178);
            this.kryptonCheckBoxCheckSize.Name = "kryptonCheckBoxCheckSize";
            this.kryptonCheckBoxCheckSize.Size = new System.Drawing.Size(80, 20);
            this.kryptonCheckBoxCheckSize.TabIndex = 12;
            this.kryptonCheckBoxCheckSize.Values.Text = "check_size";
            // 
            // kryptonCheckBoxShuffle
            // 
            this.kryptonCheckBoxShuffle.Location = new System.Drawing.Point(25, 152);
            this.kryptonCheckBoxShuffle.Name = "kryptonCheckBoxShuffle";
            this.kryptonCheckBoxShuffle.Size = new System.Drawing.Size(60, 20);
            this.kryptonCheckBoxShuffle.TabIndex = 11;
            this.kryptonCheckBoxShuffle.Values.Text = "shuffle";
            // 
            // kryptonCheckBoxGray
            // 
            this.kryptonCheckBoxGray.Location = new System.Drawing.Point(25, 126);
            this.kryptonCheckBoxGray.Name = "kryptonCheckBoxGray";
            this.kryptonCheckBoxGray.Size = new System.Drawing.Size(47, 20);
            this.kryptonCheckBoxGray.TabIndex = 10;
            this.kryptonCheckBoxGray.Values.Text = "gray";
            // 
            // kryptonLabel9
            // 
            this.kryptonLabel9.Location = new System.Drawing.Point(185, 204);
            this.kryptonLabel9.Name = "kryptonLabel9";
            this.kryptonLabel9.Size = new System.Drawing.Size(363, 20);
            this.kryptonLabel9.TabIndex = 14;
            this.kryptonLabel9.Values.Text = "When this option is on, the encoded image will be save in datum ";
            // 
            // kryptonLabel10
            // 
            this.kryptonLabel10.Location = new System.Drawing.Point(185, 178);
            this.kryptonLabel10.Name = "kryptonLabel10";
            this.kryptonLabel10.Size = new System.Drawing.Size(377, 20);
            this.kryptonLabel10.TabIndex = 13;
            this.kryptonLabel10.Values.Text = "When this option is on, check that all the datum have the same size ";
            // 
            // kryptonLabel11
            // 
            this.kryptonLabel11.Location = new System.Drawing.Point(185, 152);
            this.kryptonLabel11.Name = "kryptonLabel11";
            this.kryptonLabel11.Size = new System.Drawing.Size(303, 20);
            this.kryptonLabel11.TabIndex = 12;
            this.kryptonLabel11.Values.Text = "Randomly shuffle the order of images and their labels";
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(185, 126);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(306, 20);
            this.kryptonLabel6.TabIndex = 11;
            this.kryptonLabel6.Values.Text = "When this option is on, treat images as grayscale ones ";
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(185, 100);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(166, 20);
            this.kryptonLabel7.TabIndex = 10;
            this.kryptonLabel7.Values.Text = "Height images are resized to";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(185, 74);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(163, 20);
            this.kryptonLabel5.TabIndex = 9;
            this.kryptonLabel5.Values.Text = "Width images are resized to";
            // 
            // kryptonTextBoxResizeHeight
            // 
            this.kryptonTextBoxResizeHeight.Location = new System.Drawing.Point(124, 100);
            this.kryptonTextBoxResizeHeight.Name = "kryptonTextBoxResizeHeight";
            this.kryptonTextBoxResizeHeight.Size = new System.Drawing.Size(55, 23);
            this.kryptonTextBoxResizeHeight.TabIndex = 9;
            this.kryptonTextBoxResizeHeight.Text = "250";
            // 
            // kryptonTextBoxResizeWidth
            // 
            this.kryptonTextBoxResizeWidth.Location = new System.Drawing.Point(124, 74);
            this.kryptonTextBoxResizeWidth.Name = "kryptonTextBoxResizeWidth";
            this.kryptonTextBoxResizeWidth.Size = new System.Drawing.Size(55, 23);
            this.kryptonTextBoxResizeWidth.TabIndex = 8;
            this.kryptonTextBoxResizeWidth.Text = "250";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(25, 100);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(82, 20);
            this.kryptonLabel4.TabIndex = 6;
            this.kryptonLabel4.Values.Text = "resize_height";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(25, 74);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(77, 20);
            this.kryptonLabel3.TabIndex = 5;
            this.kryptonLabel3.Values.Text = "resize_width";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(185, 48);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(165, 20);
            this.kryptonLabel2.TabIndex = 4;
            this.kryptonLabel2.Values.Text = "The backend type of dataset";
            // 
            // kryptonRadioButtonLevelDb
            // 
            this.kryptonRadioButtonLevelDb.Location = new System.Drawing.Point(82, 48);
            this.kryptonRadioButtonLevelDb.Name = "kryptonRadioButtonLevelDb";
            this.kryptonRadioButtonLevelDb.Size = new System.Drawing.Size(62, 20);
            this.kryptonRadioButtonLevelDb.TabIndex = 7;
            this.kryptonRadioButtonLevelDb.Values.Text = "leveldb";
            // 
            // kryptonRadioButtonLmdb
            // 
            this.kryptonRadioButtonLmdb.Checked = true;
            this.kryptonRadioButtonLmdb.Location = new System.Drawing.Point(25, 48);
            this.kryptonRadioButtonLmdb.Name = "kryptonRadioButtonLmdb";
            this.kryptonRadioButtonLmdb.Size = new System.Drawing.Size(51, 20);
            this.kryptonRadioButtonLmdb.TabIndex = 6;
            this.kryptonRadioButtonLmdb.Values.Text = "lmdb";
            // 
            // kryptonTextBoxCategoryName
            // 
            this.kryptonTextBoxCategoryName.Location = new System.Drawing.Point(116, 13);
            this.kryptonTextBoxCategoryName.Name = "kryptonTextBoxCategoryName";
            this.kryptonTextBoxCategoryName.Size = new System.Drawing.Size(344, 23);
            this.kryptonTextBoxCategoryName.TabIndex = 5;
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(17, 13);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(94, 20);
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "Category name";
            // 
            // kryptonTextBoxTargetImagePath
            // 
            this.kryptonTextBoxTargetImagePath.Location = new System.Drawing.Point(135, 51);
            this.kryptonTextBoxTargetImagePath.Name = "kryptonTextBoxTargetImagePath";
            this.kryptonTextBoxTargetImagePath.Size = new System.Drawing.Size(506, 23);
            this.kryptonTextBoxTargetImagePath.TabIndex = 4;
            // 
            // kryptonTextBoxCaffePath
            // 
            this.kryptonTextBoxCaffePath.Location = new System.Drawing.Point(135, 20);
            this.kryptonTextBoxCaffePath.Name = "kryptonTextBoxCaffePath";
            this.kryptonTextBoxCaffePath.Size = new System.Drawing.Size(506, 23);
            this.kryptonTextBoxCaffePath.TabIndex = 2;
            // 
            // kryptonButtonTargetImagePath
            // 
            this.kryptonButtonTargetImagePath.Location = new System.Drawing.Point(647, 48);
            this.kryptonButtonTargetImagePath.Name = "kryptonButtonTargetImagePath";
            this.kryptonButtonTargetImagePath.Size = new System.Drawing.Size(105, 25);
            this.kryptonButtonTargetImagePath.TabIndex = 3;
            this.kryptonButtonTargetImagePath.Values.Text = "select";
            this.kryptonButtonTargetImagePath.Click += new System.EventHandler(this.kryptonButtonTargetImagePath_Click);
            // 
            // kryptonButtonCaffeLibPathSet
            // 
            this.kryptonButtonCaffeLibPathSet.Location = new System.Drawing.Point(647, 17);
            this.kryptonButtonCaffeLibPathSet.Name = "kryptonButtonCaffeLibPathSet";
            this.kryptonButtonCaffeLibPathSet.Size = new System.Drawing.Size(105, 25);
            this.kryptonButtonCaffeLibPathSet.TabIndex = 1;
            this.kryptonButtonCaffeLibPathSet.Values.Text = "select";
            this.kryptonButtonCaffeLibPathSet.Click += new System.EventHandler(this.kryptonButtonCaffeLibPathSet_Click);
            // 
            // kryptonSplitContainer1
            // 
            this.kryptonSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.kryptonSplitContainer1.Name = "kryptonSplitContainer1";
            this.kryptonSplitContainer1.Size = new System.Drawing.Size(778, 503);
            this.kryptonSplitContainer1.SplitterDistance = 176;
            this.kryptonSplitContainer1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1471530786_image.png");
            this.imageList1.Images.SetKeyName(1, "1471530807_image.ico");
            this.imageList1.Images.SetKeyName(2, "1471585568_Grid.ico");
            this.imageList1.Images.SetKeyName(3, "1471585584_List.ico");
            this.imageList1.Images.SetKeyName(4, "1471585599_Menu2.ico");
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "키워드";
            this.columnHeader1.Width = 255;
            // 
            // kryptonComboBoxSize
            // 
            this.kryptonComboBoxSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonComboBoxSize.DropDownWidth = 190;
            this.kryptonComboBoxSize.Items.AddRange(new object[] {
            "",
            "400x300",
            "640x480",
            "800x600",
            "1024x768"});
            this.kryptonComboBoxSize.Location = new System.Drawing.Point(105, 93);
            this.kryptonComboBoxSize.Name = "kryptonComboBoxSize";
            this.kryptonComboBoxSize.Size = new System.Drawing.Size(190, 21);
            this.kryptonComboBoxSize.TabIndex = 11;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 515);
            this.Controls.Add(this.kryptonNavigator1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "GoogleDownloader";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxUploaded)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGoogleDownloader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKeywordPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonNavigator1)).EndInit();
            this.kryptonNavigator1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage3)).EndInit();
            this.kryptonPage3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5.Panel)).EndInit();
            this.kryptonGroupBox5.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox5)).EndInit();
            this.kryptonGroupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4.Panel)).EndInit();
            this.kryptonGroupBox4.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox4)).EndInit();
            this.kryptonGroupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3.Panel)).EndInit();
            this.kryptonGroupBox3.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox3)).EndInit();
            this.kryptonGroupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2.Panel)).EndInit();
            this.kryptonGroupBox2.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox2)).EndInit();
            this.kryptonGroupBox2.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage4)).EndInit();
            this.kryptonPage4.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6.Panel)).EndInit();
            this.kryptonGroupBox6.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox6)).EndInit();
            this.kryptonGroupBox6.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox7.Panel)).EndInit();
            this.kryptonGroupBox7.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox7)).EndInit();
            this.kryptonGroupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox8.Panel)).EndInit();
            this.kryptonGroupBox8.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox8)).EndInit();
            this.kryptonGroupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox9.Panel)).EndInit();
            this.kryptonGroupBox9.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox9)).EndInit();
            this.kryptonGroupBox9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPage2)).EndInit();
            this.kryptonPage2.ResumeLayout(false);
            this.panelConvertDB.ResumeLayout(false);
            this.panelConvertDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1.Panel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonSplitContainer1)).EndInit();
            this.kryptonSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonComboBoxSize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox pictureBoxGoogleDownloader;
        private System.Windows.Forms.PictureBox pictureBoxKeywordPreview;
        private System.Windows.Forms.PictureBox pictureBoxUploaded;
        private System.Windows.Forms.ImageList imageList1;
        private ComponentFactory.Krypton.Navigator.KryptonNavigator kryptonNavigator1;
        private ComponentFactory.Krypton.Toolkit.KryptonSplitContainer kryptonSplitContainer1;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage2;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage3;
        private ComponentFactory.Krypton.Navigator.KryptonPage kryptonPage4;
        private System.Windows.Forms.Panel panelConvertDB;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonConvertDBRun;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxDBSavePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonDBSavePath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxDBName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel12;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxEncodeType;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxEncodeType;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxEncode;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxCheckSize;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxShuffle;
        private ComponentFactory.Krypton.Toolkit.KryptonCheckBox kryptonCheckBoxGray;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel8;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel10;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel11;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxResizeHeight;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxResizeWidth;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonLevelDb;
        private ComponentFactory.Krypton.Toolkit.KryptonRadioButton kryptonRadioButtonLmdb;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxCategoryName;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxTargetImagePath;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxCaffePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonTargetImagePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonCaffeLibPathSet;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox5;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox3;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel13;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel16;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonKeywordOpen;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonImageSavePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonDownloadStart;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxKeywordFile;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxSavePath;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBoxKeyword;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBoxImgDownloadURL;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox7;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox8;
        private ComponentFactory.Krypton.Toolkit.KryptonGroupBox kryptonGroupBox9;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel17;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel18;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonOpenGoogleDownloaderFile;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonGoogleDownloaderSavePath;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonGoogleDownloaderStart;
        public ComponentFactory.Krypton.Toolkit.KryptonListBox kryptonListBoxGoogleDownloader;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxGoogleDownloaderURL;
        public ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxGoogleDownloaderSavePath;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel19;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel20;
        private System.Windows.Forms.ToolTip toolTip1;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel23;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel22;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel21;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxImageCountKey;
        internal ComponentFactory.Krypton.Toolkit.KryptonTextBox kryptonTextBoxImageCountURL;
        private ComponentFactory.Krypton.Toolkit.KryptonLabel kryptonLabel14;
        public ComponentFactory.Krypton.Toolkit.KryptonComboBox kryptonComboBoxSize;
    }
}

