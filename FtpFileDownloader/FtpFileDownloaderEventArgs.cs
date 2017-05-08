using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FtpFileDownloader
{
    class FtpFileDownloaderEventArgs
    {
        //Class to hold various file transfer statistic
        public FtpFileDownloaderEventArgs(long fileSize, long bytesDownloaded, long millisecondsElapsed)
        {
            //properties are calculated in constructor and are read-only for class user
            DownloadedBytes = bytesDownloaded;
            DownloadedPercentage = (int)((double)bytesDownloaded / fileSize * 100);
            TransferRateKBps = millisecondsElapsed==0?0:(bytesDownloaded * 1000) / (millisecondsElapsed * 1024);
            EstimatedTimeLeft = TransferRateKBps==0?0:(int)((fileSize - bytesDownloaded) / (TransferRateKBps*1024));
        }
        public long DownloadedBytes { get; private set; }

        public int DownloadedPercentage { get; private set; }

        public long TransferRateKBps { get; private set; }

        public int EstimatedTimeLeft { get; private set; }

    }
}
