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

        public HomePage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }
        
        public int getExamplesCount()
        {
            throw new NotImplementedException();
        }

        public string getForkmeDetails()
        {
            throw new NotImplementedException();
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
