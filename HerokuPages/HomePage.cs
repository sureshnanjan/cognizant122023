using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace HerokuPages
{
    public class HomePage : IHomePageOperations
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/";
        private By headingLocator = By.TagName("h1");
        private By subHeadingLocator = By.TagName("h2");
        private string _strClassnameForDeleteButton = "added-manually";
        private string _strGetTheLinksByElements = "//*[@id='content']/ul/li";

        public HomePage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }
        
        public int getExamplesCount()
        {
            return _browser.FindElements(By.XPath(_strGetTheLinksByElements)).Count;
        }

        public string getForkmeDetails()
        {
            _browser.FindElement(By.CssSelector("Fork me on GitHub")).Click();
            //div.row:nth - child(2) > img:nth - child(2)
                /// html / body / div[2] / img
            //_browser.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            return _browser.Url.ToString();
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public string getSubHeading()
        {
            return _browser.FindElement(subHeadingLocator).Text;
        }

        public void goToExample(string exampleName)
        {
            throw new NotImplementedException();
        }

        private void CloseBrowser() {
            _browser.Quit();
        }

        public void exitApplication()
        {
            CloseBrowser();
        }
    }
}
