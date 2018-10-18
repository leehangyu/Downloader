namespace WindowsFormsApplication1
{
    partial class ProgressFormGoogleDownloaderFromURI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressFormGoogleDownloaderFromURI));
            this.progressBarFromURI = new System.Windows.Forms.ProgressBar();
            this.kryptonButtonStop = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.SuspendLayout();
            // 
            // progressBarFromURI
            // 
            this.progressBarFromURI.Dock = System.Windows.Forms.DockStyle.Left;
            this.progressBarFromURI.Location = new System.Drawing.Point(6, 6);
            this.progressBarFromURI.MarqueeAnimationSpeed = 30;
            this.progressBarFromURI.Name = "progressBarFromURI";
            this.progressBarFromURI.Size = new System.Drawing.Size(463, 24);
            this.progressBarFromURI.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarFromURI.TabIndex = 0;
            // 
            // kryptonButtonStop
            // 
            this.kryptonButtonStop.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonButtonStop.Location = new System.Drawing.Point(475, 6);
            this.kryptonButtonStop.Name = "kryptonButtonStop";
            this.kryptonButtonStop.Size = new System.Drawing.Size(24, 24);
            this.kryptonButtonStop.TabIndex = 1;
            this.kryptonButtonStop.Values.Image = global::GoogleDownloader.Properties.Resources.stop;
            this.kryptonButtonStop.Values.Text = "";
            this.kryptonButtonStop.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // ProgressFormGoogleDownloaderFromURI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 36);
            this.ControlBox = false;
            this.Controls.Add(this.kryptonButtonStop);
            this.Controls.Add(this.progressBarFromURI);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressFormGoogleDownloaderFromURI";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Downloading";
            this.Load += new System.EventHandler(this.ProgressFormGoogleDownloaderFromURI_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarFromURI;
        private ComponentFactory.Krypton.Toolkit.KryptonButton kryptonButtonStop;
    }
}