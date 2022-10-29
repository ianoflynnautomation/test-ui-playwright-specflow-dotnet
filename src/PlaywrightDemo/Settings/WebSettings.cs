
namespace Practice.One.UI.Settings.Configuration
{
    public sealed class WebSettings
    {
        public string BaseUrl { get; set; }
        public BrowserSettings Chrome { get; set; }
        public int ElementWaitTimeout { get; set; }
        public bool HeadLess { get; set; }
        public int SlowMo { get; set; }
    }
}
