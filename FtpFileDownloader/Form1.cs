using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FtpFileDownloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void DownloadButton_Click(object sender, EventArgs e)
        { 
            //Download file in separate thread in order for form to be responisve and easily update statistics
            backgroundWorker.RunWorkerAsync(); 
        }

        private void DownloadFileFromFtp(object sender, DoWorkEventArgs e)
        {
            //Callend on backgroundWorker.RunWorkerAsync();  
            //all disposable objects moved inside using clauses 
            //Exceptions are handled in rather bad style, but seems OK for this project purposes
            try
            {
                //Ask for ftp file
                using (FtpWebResponse response = GetFtpResponse())
                {
                    //get stream from response
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        //generate fileName from request (simplest solution possible)
                        string fileName = Path.GetFileName(response.ResponseUri.ToString()); 
                        //get file size
                        long size = GetFileSize();

                        //Create filestream for write, read and write file in 1 kB pieces, overvrite existing in app Folder
                        using (FileStream fileStream = new FileStream(fileName, FileMode.Create))
                        {
                            //check if we reached end of the stream
                            int read = -1;
                            //start stopwatch for measuring time elapsed from the beginning of download
                            Stopwatch stopwatch = Stopwatch.StartNew(); 
                            //while not end of stream 
                            while (read != 0)
                            {
                                //1kB buffer
                                byte[] buffer = new byte[1024];
                                //Read a piece of stream (can be replaced with ReadAsync(), than yield IEnumerable of byte[] and write whole file at once)
                                int count = responseStream.Read(buffer, 0, 1024); 
                                //write the piece which was just read
                                fileStream.Write(buffer, 0, count); 
                                //update statistics
                                backgroundWorker.ReportProgress(0, new FtpFileDownloaderEventArgs(size, fileStream.Length, stopwatch.ElapsedMilliseconds));
                                //check if anything was read
                                read = count;
                            }
                            //stop time measurements
                            stopwatch.Stop();
                        }
                    }
                }
            }
            catch (Exception)
            {
                //Inform user about exception
                MessageBox.Show("Exception happened... File Not Downloaded.");
            }
        }

        private FtpWebResponse GetFtpResponse()
        {
            //CreateFtpRequest
            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FtpResourceAddress.Text); 
            //Set method to DownloadFile
            ftpWebRequest.Method = WebRequestMethods.Ftp.DownloadFile;

            //UserName and password, if needed
            ftpWebRequest.Credentials = new NetworkCredential(Username.Text, Password.Text);

            //return response
            FtpWebResponse response = (FtpWebResponse)ftpWebRequest.GetResponse();
            return response;
        }

        private long GetFileSize()
        {
            //creater ftp Request
            FtpWebRequest ftpWebRequest = (FtpWebRequest)WebRequest.Create(FtpResourceAddress.Text);
            //Get  file size in response via content length
            ftpWebRequest.Method = WebRequestMethods.Ftp.GetFileSize;
            FtpWebResponse sizeResponse = (FtpWebResponse)ftpWebRequest.GetResponse();
            long size = sizeResponse.ContentLength;
            //no need to hold reference to response any more
            sizeResponse.Close();
            return size;
        }

        private void UpdateStatistics(object sender, ProgressChangedEventArgs e)
        {
            //Custom class for various statistics
            FtpFileDownloaderEventArgs eventArgs = e.UserState as FtpFileDownloaderEventArgs;
            //Update various statistics
            ProgressBar.Value = eventArgs.DownloadedPercentage;
            Label_TransferRate.Text = "Transfer rate: " + eventArgs.TransferRateKBps + " kBps";
            Label_DownloadedBytes.Text = "Bytes downloaded: " + eventArgs.DownloadedBytes; 
            Label_TimeRemaining.Text = "Time remaining: " + eventArgs.EstimatedTimeLeft + " seconds"; 

 
        }

        private void ShowMessageFileDownloaded(object sender, RunWorkerCompletedEventArgs e)
        {
            //Tell the user that file was downloaded successfully
            MessageBox.Show("File download complete");
        }

    }
}
