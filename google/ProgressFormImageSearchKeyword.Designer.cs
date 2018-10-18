namespace WindowsFormsApplication1
{
    partial class ProgressFormGoogleDownloaderKeyword
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressFormGoogleDownloaderKeyword));
            this.progressBarKeyword = new System.Windows.Forms.ProgressBar();
            this.kryptonButtonStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // progressBarKeyword
            // 
            this.progressBarKeyword.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBarKeyword.Location = new System.Drawing.Point(6, 6);
            this.progressBarKeyword.MarqueeAnimationSpeed = 30;
            this.progressBarKeyword.Name = "progressBarKeyword";
            this.progressBarKeyword.Size = new System.Drawing.Size(465, 23);
            this.progressBarKeyword.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarKeyword.TabIndex = 0;
            // 
            // kryptonButtonStop
            // 
            this.kryptonButtonStop.Cursor = System.Windows.Forms.Cursors.Default;
            this.kryptonButtonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonStop.Location = new System.Drawing.Point(475, 6);
            this.kryptonButtonStop.Name = "kryptonButtonStop";
            this.kryptonButtonStop.Size = new System.Drawing.Size(24, 23);
            this.kryptonButtonStop.TabIndex = 1;
            this.kryptonButtonStop.Values.Image = global::GoogleDownloader.Properties.Resources.stop;
            this.kryptonButtonStop.Values.Text = "";
            this.kryptonButtonStop.Click += new System.EventHandler(this.kryptonButtonStop_Click);
            // 
            // ProgressFormGoogleDownloaderKeyword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 35);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonButtonStop);
            this.Controls.Add(this.progressBarKeyword);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressFormGoogleDownloaderKeyword";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Downloading";
            this.Load += new System.EventHandler(this.ProgressFormGoogleDownloaderKeyword_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarKeyword;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonStop;
    }
}