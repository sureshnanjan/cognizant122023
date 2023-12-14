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
        private string _url = "https://the-internet.herokuapp.com/add_remove_elements/";
        private By heading = By.TagName("h3");

        public AddRemoveElementsPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public void addElement()
        {
            //*[@id="content"]/div
            _browser.FindElement(By.XPath("//*[@id='content']/div/button")).Click();

        }

        public int getAddedElemenstCount()
        {
           return _browser.FindElements(By.XPath("//*[@id='content']/div/button")).Count;
        }

        public string getHeading()
        {
            return _browser.FindElement(heading).Text;
        }

        public void removeElement()
        {
            _browser.FindElement(By.XPath("//*[@id='elements']/button")).Click();
        }
    }
}
