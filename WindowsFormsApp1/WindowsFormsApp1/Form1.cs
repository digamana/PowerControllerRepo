using MediaToolkit;
using MediaToolkit.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoLibrary;
using YoutubeExtractor;

namespace WindowsFormsApp1
{
    //參考https://stackoverflow.com/questions/39877884/c-sharp-download-the-sound-of-a-youtube-video
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Our test youtube link
            string link = "https://youtu.be/BEULybZnLO8?list=PL-hbRWzlrBjcFaQaStciosX1eeUUA__1S";

            /*
             * Get the available video formats.
             * We'll work with them in the video and audio download examples.
             */
            IEnumerable<YoutubeExtractor.VideoInfo> videoInfos = DownloadUrlResolver.GetDownloadUrls(link);

        }
        public static void Example1()
        {
            var source = @"F:\";
            var youtube = YouTube.Default;
            var vid = youtube.GetVideo("https://youtu.be/NEh3-Qmq1LE?list=PL-hbRWzlrBjcFaQaStciosX1eeUUA__1S");

            File.WriteAllBytes(source + vid.FullName, vid.GetBytes());

            var inputFile = new MediaFile { Filename = source + vid.FullName };
            var outputFile = new MediaFile { Filename = $"{source + vid.FullName}.mp3" };

            using (var engine = new Engine())
            {
                //engine.GetMetadata(inputFile);

                engine.Convert(inputFile, outputFile);
            }
        }
        public static void Example2()
        {
            //Nuget YoutubeExtractor 
            IEnumerable<YoutubeExtractor.VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls("https://youtu.be/oJHIMjkhoyU?list=PL-hbRWzlrBjcFaQaStciosX1eeUUA__1S");
            YoutubeExtractor.VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32("360"));
            if (video.RequiresDecryption)
                DownloadUrlResolver.DecryptDownloadUrl(video);
            //Download video
            VideoDownloader downloader = new VideoDownloader(video, Path.Combine(Application.StartupPath + "\\", video.Title + video.VideoExtension));
 
            //Create a new thread to download file
            Thread thread = new Thread(() => { downloader.Execute(); }) { IsBackground = true };
            thread.Start();
        }
    }
}
