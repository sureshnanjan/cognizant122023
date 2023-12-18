using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Specialized;
using System.Configuration;
using HerokuAppOperations;
using System.Linq;

namespace HerokuPages
{
    public class SeleniumFactory
    {
        private static WebAutomationConfiguration _settings = getApplicationParams();
        private  static WebAutomationConfiguration getApplicationParams()
        {
            var setting = readAppSettings();
            return new WebAutomationConfiguration(setting.url.Trim().EndsWith("/") ? setting.url.Trim() : setting.url.Trim().Append('/').ToString(),
                setting.browser);

        }


        private static (string url, string browser) readAppSettings()
        {
            var applicationSettings = ConfigurationManager.GetSection("WebAppSettings") as NameValueCollection;
            if (applicationSettings.Count == 0)
            {
                Console.WriteLine("Application Settings are not defined");
                return (default, default);
            }
            else
            {
                return (applicationSettings["url"], applicationSettings["browser"]);
            }


        }

        public static IWebDriver getBrowser() {
            switch (_settings.Browser)
            {
                case "firefox": return new FirefoxDriver();
                case "edge": return new EdgeDriver();
                case "ie": return new InternetExplorerDriver();
                case "chrome": 
                default:
                    return new ChromeDriver();
            }
        }

        public static string getUrl() {
            return _settings.Appurl;
        }
    }
}
