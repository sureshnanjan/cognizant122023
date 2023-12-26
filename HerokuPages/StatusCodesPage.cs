using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;

namespace HerokuPages
{
   public class StatusCodesPage : HerokuApplication, IStatus_Codes, IHerokuApp
    {
      
        private By headingLocator = By.TagName("h3");
       
        public StatusCodesPage(IWebDriver driver) : base(driver)
        {
            
        }


        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }


        public int getStatusCodesCount()
        {
            return _browser.FindElements(By.XPath("//*[@id=\"content\"]/div/ul/li")).Count;
        }

        IHerokuApp IStatus_Codes.goToStatusCodes(string exampleName)
        {
            _browser.FindElement(By.LinkText(exampleName)).Click();
            return this;
        }


        public void goToStatusCodeCompleteList()
        {
            
             this._browser.FindElement(By.XPath("//*[@id='content']/div/p/a")).Click();
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

