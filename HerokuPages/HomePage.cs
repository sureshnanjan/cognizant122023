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
        //private string ExampleName = "A/B Testing";

        public HomePage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }
        
        public int getExamplesCount()
        {
            var liElements = _browser.FindElements(By.XPath("//*[@id='content']/ul/li"));
            int liCount = liElements.Count;
            return liCount;

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

        public string goToExample(string exampleName)
        {
            _browser.FindElement(By.XPath($"//*[@id='content']/ul/li/a[text()='{exampleName}']")).Click();
            string pageheading = _browser.FindElement(By.XPath("//*[@id='content']/div/h3")).Text;
            return pageheading;

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
