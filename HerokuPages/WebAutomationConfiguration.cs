namespace HerokuPages
{
    class WebAutomationConfiguration
    {
        public WebAutomationConfiguration(string url, string browser)
        {
            Appurl = url;
            Browser = browser;
        }

        public string Appurl { get; set; } = default;
        public string Browser { get; set; } = default;
    }
}