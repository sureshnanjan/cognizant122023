using HerokuAppOperations;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class SlowResources : ISlowResources
    {
        protected IWebDriver _browser = default;
        public string getDescription()
        {
            return this._browser.FindElement(By.TagName("h3")).Text;
        }

        public string getHeading()
        {
            return this._browser.FindElement(By.TagName("h1")).Text;
        }

        public int getLoadTime()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)_browser;
            var ResponseTime = Convert.ToInt32(js.ExecuteScript("return " +
                "window.performance.timing.timing.domContentLoadedEventEndwindow.performance.timing.navigationStart;"));
            return ResponseTime;
        }

        public void Load()
        {
            this._browser.Navigate();
        }
    }
}
