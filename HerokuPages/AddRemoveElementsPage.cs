using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;

namespace HerokuPages
{
    public class AddRemoveElementsPage : IAddRemoveElements

    {
        HomePage hp = new HomePage();
        private By headingLocator = By.TagName("h3");
        public void addElement()
        {
            hp.browserobj().FindElement(By.LinkText("Add/Remove Elements")).Click();
            hp.browserobj().FindElement(By.XPath("//*[@id='content']/div/button")).Click();
        }
        

        public int getAddedElemenstCount()
        {
            hp.browserobj().FindElement(By.XPath("//*[@id='content']/ul/li[2]/a")).Click();
            // Action to Add Elemsnt
           // hp.browserobj().FindElement(By.XPath("//*[@id='content']/div/button")).Click();
            // Assert that a new element got added
            int noofElemenstAdded = hp.browserobj().FindElements(By.ClassName("added-manually")).Count;

            return noofElemenstAdded;
        }

        public string getHeading()
        {
            return hp.browserobj().FindElement(headingLocator).Text;
        }

        public void removeElement()
        {
            throw new NotImplementedException();
        }
    }
}
