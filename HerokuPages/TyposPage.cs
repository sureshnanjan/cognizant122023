using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class TyposPage
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/typos";
        private By headingLocator = By.TagName("h3");

        public TyposPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public string getPageDescription()
        {
            string description = _browser.FindElement(By.XPath("//*[@id=\"content\"]/div/p[1]/text()")).Text;
            description = description + _browser.FindElement(By.Id("$0")).Text;
            return description;
        }

        public bool checkForTypos()
        {
            string result = getPageDescription();
            if (result.Contains("won,t")) 
            {
                return true;
            }
            return false;

        }

        private void CloseBrowser()
        {
            _browser.Quit();
        }

        public void exitApplication()
        {
            CloseBrowser();
        }
    }
}
