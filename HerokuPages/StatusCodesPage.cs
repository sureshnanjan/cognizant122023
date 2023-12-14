using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class StatusCodesPage
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/status_codes";
        private By headingLocator = By.TagName("h3");

        public StatusCodesPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public int gettatusCodeCount()
        {
            return _browser.FindElements(By.XPath("//*[@id=\"content\"]/div/ul/li")).Count;
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public void goToStatusCode(string exampleName)
        {
            _browser.FindElement(By.LinkText(exampleName)).Click();
        }

        public void goToStatusCodeCompleteList()
        {
            _browser.FindElement(By.LinkText("here")).Click();
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
