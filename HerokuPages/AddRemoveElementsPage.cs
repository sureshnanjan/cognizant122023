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
    class AddRemoveElementsPage : IAddRemoveElements
    {
        private IWebDriver _browser;
        public void addElement()
        {
            _browser.FindElement(By.XPath("//button[@onclick='addElement()']")).Click();
        }

        public int getAddedElemenstCount()
        {
            throw new NotImplementedException();
        }

        public string getHeading()
        {
            throw new NotImplementedException();
        }

        public void removeElement()
        {
            throw new NotImplementedException();
        }
    }
}
