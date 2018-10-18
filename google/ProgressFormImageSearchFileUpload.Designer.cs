namespace WindowsFormsApplication1
{
    partial class ProgressFormGoogleDownloaderFileUpload
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProgressFormGoogleDownloaderFileUpload));
            this.progressBarFileUpload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // progressBarFileUpload
            // 
            this.progressBarFileUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBarFileUpload.Location = new System.Drawing.Point(6, 6);
            this.progressBarFileUpload.MarqueeAnimationSpeed = 30;
            this.progressBarFileUpload.Name = "progressBarFileUpload";
            this.progressBarFileUpload.Size = new System.Drawing.Size(493, 23);
            this.progressBarFileUpload.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBarFileUpload.TabIndex = 0;
            this.progressBarFileUpload.UseWaitCursor = true;
            // 
            // ProgressFormGoogleDownloaderFileUpload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 35);
            this.ControlBox = false;
            this.Controls.Add(this.progressBarFileUpload);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProgressFormGoogleDownloaderFileUpload";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uploading";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.ProgressFormGoogleDownloaderFileUpload_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBarFileUpload;
    }
}