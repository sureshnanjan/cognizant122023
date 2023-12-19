using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace HerokuPages
{
    public class HomePage : IHomePageOperations,IContextMenu
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
        public void clickonpagelink()
        {
            _browser.FindElement(By.LinkText("Context Menu")).Click();
        }
        public string getHeadingOnClick()
        {
            //string heading = string.Empty;
            _browser = new ChromeDriver();
            By heading = By.TagName("h3");
            return _browser.FindElement(heading).Text;
        }
       public string GetBoxclicknalrt()
        {
            string str = string.Empty;
            Actions actions = new Actions(_browser);
            By heading = By.TagName("hot-spot");
            WebElement clickable =(WebElement)_browser.FindElement(heading);
            actions.ContextClick(clickable);
            str = _browser.SwitchTo().Alert().Text;
            return str;
        }

        public void exitApplication()
        {
            CloseBrowser();
        }
    }
}
