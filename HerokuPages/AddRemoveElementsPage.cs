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
    public class AddRemoveElementsPage : IAddRemoveElements
    {
        private IWebDriver _browser;
        private string _urlAddRemove = "https://the-internet.herokuapp.com/add_remove_elements/";
        private By headingLocator = By.TagName("h3");

        public AddRemoveElementsPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_urlAddRemove);
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public void addElement()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/button")).Click();
            
        }

        public void removeElement()
        {
            throw new NotImplementedException();
            
        }

        public int getAddedElemenstCount()
        {
           return _browser.FindElements(By.XPath("//*[@id='elements']/button")).Count;
           
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
