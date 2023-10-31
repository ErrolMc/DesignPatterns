
namespace DesignPatterns.Structural.Proxy
{
    // https://refactoring.guru/design-patterns/proxy
    public class ProxyPatternRunner : PatternRunner
    {
        public override void Run()
        {
            YouTubeService realYoutubeService = new YouTubeService();
            IYouTubeService proxyYoutubeService = new CachedYouTubeService(realYoutubeService);

            Console.WriteLine("[Proxy] First request for video A:");
            Video videoA = proxyYoutubeService.GetVideo("A");

            Console.WriteLine("[Proxy] Second request for video A (should be cached):");
            Video cachedVideoA = proxyYoutubeService.GetVideo("A");

            Console.WriteLine("[Proxy] Request for video B (not cached):");
            Video videoB = proxyYoutubeService.GetVideo("B");
        }
    }
}
