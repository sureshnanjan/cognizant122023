using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Security.Policy;

namespace HerokuPages
{
    public class HerokuApplication : IHerokuApp
    {
        protected IWebDriver _browser = default;
        private string _url = default;
        private By headingLocator; //= By.TagName("h1");
        private By subHeadingLocator; //= By.TagName("h2");
        private bool componentsInitialized = false;

        public HerokuApplication(IWebDriver driver)
        {
            this._browser = driver;
            //this._url = url;
            headingLocator = By.TagName("h1");
            subHeadingLocator = By.TagName("h2");
        }

        public HerokuApplication()
        {

        }

        private void initialize() {
            if (!componentsInitialized)
            {
                try
                {
                    this._browser = SeleniumFactory.getBrowser();
                    this._url = SeleniumFactory.getUrl();
                    componentsInitialized = true;
                }
                catch (Exception exc) {
                    componentsInitialized = false;
                }
                
            }
            
        }

        public bool checkStatus()
        {
            throw new System.NotImplementedException();
        }

        public string getFooterLink()
        {
            throw new System.NotImplementedException();
        }

        public string getFooterText()
        {
            throw new System.NotImplementedException();
        }

        public string getUrl()
        {
            throw new System.NotImplementedException();
        }

        public IHerokuApp goToHome()
        {
            this._browser.Navigate().GoToUrl(this._url);
            return new HomePage(_browser);
        }

        public void handleErrors()
        {
            throw new System.NotImplementedException();
        }
        private void CloseBrowser()
        {
            _browser.Quit();
        }


        public void exitApplication()
        {
            CloseBrowser();
        }

        /// <summary>
        /// This is the factory method to obtain an Instance of configured browser and app Url
        /// </summary>
        /// <returns></returns>
        public IHerokuApp getApplicationInstance()
        {
            initialize();
            return this;
        }

        public string getHeading()
        {
            return this._browser.FindElement(headingLocator).Text;
        }

        public string getSubHeading()
        {
            return this._browser.FindElement(subHeadingLocator).Text;
        }
    }
}
