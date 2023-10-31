using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    // RealObject
    public class YouTubeService : IYouTubeService
    {
        public Video GetVideo(string videoID)
        {
            Console.WriteLine("[Proxy] Downloading from YouTube: " + videoID);
            return new Video(videoID);
        }
    }
}
