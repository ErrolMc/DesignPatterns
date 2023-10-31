using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.Proxy
{
    // Proxy
    public class CachedYouTubeService : IYouTubeService
    {
        private YouTubeService youtubeService;
        private Dictionary<string, Video> videoCache;

        public CachedYouTubeService(YouTubeService youtubeService)
        {
            this.youtubeService = youtubeService;
            videoCache = new Dictionary<string, Video>();
        }

        public Video GetVideo(string videoID)
        {
            if (videoCache.ContainsKey(videoID))
            {
                Console.WriteLine("[Proxy] Fetching video from cache: " + videoID);
                return videoCache[videoID];
            }

            Video video = youtubeService.GetVideo(videoID);
            videoCache[videoID] = video;

            return video;
        }
    }
}
