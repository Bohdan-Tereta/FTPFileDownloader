namespace FtpFileDownloader
{
    partial class Form1
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
            this.FtpResourceAddress = new System.Windows.Forms.TextBox();
            this.Username = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.Label_FtpResourceAddress = new System.Windows.Forms.Label();
            this.Label_Username = new System.Windows.Forms.Label();
            this.Label_Password = new System.Windows.Forms.Label();
            this.DownloadButton = new System.Windows.Forms.Button();
            this.ProgressBar = new System.Windows.Forms.ProgressBar();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.Label_TransferRate = new System.Windows.Forms.Label();
            this.Label_DownloadedBytes = new System.Windows.Forms.Label();
            this.Label_TimeRemaining = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FtpResourceAddress
            // 
            this.FtpResourceAddress.Location = new System.Drawing.Point(35, 29);
            this.FtpResourceAddress.Name = "FtpResourceAddress";
            this.FtpResourceAddress.Size = new System.Drawing.Size(207, 22);
            this.FtpResourceAddress.TabIndex = 0;
            // 
            // Username
            // 
            this.Username.Location = new System.Drawing.Point(35, 77);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(207, 22);
            this.Username.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(35, 128);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(207, 22);
            this.Password.TabIndex = 2;
            // 
            // Label_FtpResourceAddress
            // 
            this.Label_FtpResourceAddress.AutoSize = true;
            this.Label_FtpResourceAddress.Location = new System.Drawing.Point(32, 9);
            this.Label_FtpResourceAddress.Name = "Label_FtpResourceAddress";
            this.Label_FtpResourceAddress.Size = new System.Drawing.Size(143, 17);
            this.Label_FtpResourceAddress.TabIndex = 3;
            this.Label_FtpResourceAddress.Text = "Ftp resource address";
            // 
            // Label_Username
            // 
            this.Label_Username.AutoSize = true;
            this.Label_Username.Location = new System.Drawing.Point(32, 57);
            this.Label_Username.Name = "Label_Username";
            this.Label_Username.Size = new System.Drawing.Size(73, 17);
            this.Label_Username.TabIndex = 4;
            this.Label_Username.Text = "Username";
            // 
            // Label_Password
            // 
            this.Label_Password.AutoSize = true;
            this.Label_Password.Location = new System.Drawing.Point(32, 108);
            this.Label_Password.Name = "Label_Password";
            this.Label_Password.Size = new System.Drawing.Size(69, 17);
            this.Label_Password.TabIndex = 5;
            this.Label_Password.Text = "Password";
            // 
            // DownloadButton
            // 
            this.DownloadButton.Location = new System.Drawing.Point(35, 156);
            this.DownloadButton.Name = "DownloadButton";
            this.DownloadButton.Size = new System.Drawing.Size(100, 23);
            this.DownloadButton.TabIndex = 6;
            this.DownloadButton.Text = "Download";
            this.DownloadButton.UseVisualStyleBackColor = true;
            this.DownloadButton.Click += new System.EventHandler(this.DownloadButton_Click);
            // 
            // ProgressBar
            // 
            this.ProgressBar.Location = new System.Drawing.Point(35, 311);
            this.ProgressBar.MarqueeAnimationSpeed = 0;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(207, 23);
            this.ProgressBar.TabIndex = 7;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DownloadFileFromFtp);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.UpdateStatistics);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.ShowMessageFileDownloaded);
            // 
            // Label_TransferRate
            // 
            this.Label_TransferRate.AutoSize = true;
            this.Label_TransferRate.Location = new System.Drawing.Point(32, 203);
            this.Label_TransferRate.Name = "Label_TransferRate";
            this.Label_TransferRate.Size = new System.Drawing.Size(104, 17);
            this.Label_TransferRate.TabIndex = 8;
            this.Label_TransferRate.Text = "Transfer Rate: ";
            // 
            // Label_DownloadedBytes
            // 
            this.Label_DownloadedBytes.AutoSize = true;
            this.Label_DownloadedBytes.Location = new System.Drawing.Point(32, 233);
            this.Label_DownloadedBytes.Name = "Label_DownloadedBytes";
            this.Label_DownloadedBytes.Size = new System.Drawing.Size(132, 17);
            this.Label_DownloadedBytes.TabIndex = 9;
            this.Label_DownloadedBytes.Text = "Downloaded bytes: ";
            // 
            // Label_TimeRemaining
            // 
            this.Label_TimeRemaining.AutoSize = true;
            this.Label_TimeRemaining.Location = new System.Drawing.Point(32, 264);
            this.Label_TimeRemaining.Name = "Label_TimeRemaining";
            this.Label_TimeRemaining.Size = new System.Drawing.Size(113, 17);
            this.Label_TimeRemaining.TabIndex = 10;
            this.Label_TimeRemaining.Text = "Time remaining: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 346);
            this.Controls.Add(this.Label_TimeRemaining);
            this.Controls.Add(this.Label_DownloadedBytes);
            this.Controls.Add(this.Label_TransferRate);
            this.Controls.Add(this.ProgressBar);
            this.Controls.Add(this.DownloadButton);
            this.Controls.Add(this.Label_Password);
            this.Controls.Add(this.Label_Username);
            this.Controls.Add(this.Label_FtpResourceAddress);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.FtpResourceAddress);
            this.Name = "Form1";
            this.Text = "FtpFileDownloader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox FtpResourceAddress;
        private System.Windows.Forms.TextBox Username;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label Label_FtpResourceAddress;
        private System.Windows.Forms.Label Label_Username;
        private System.Windows.Forms.Label Label_Password;
        private System.Windows.Forms.Button DownloadButton;
        private System.Windows.Forms.ProgressBar ProgressBar;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.Label Label_TransferRate;
        private System.Windows.Forms.Label Label_DownloadedBytes;
        private System.Windows.Forms.Label Label_TimeRemaining;
    }
}

