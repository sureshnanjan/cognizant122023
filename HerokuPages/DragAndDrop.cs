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
   
    public class DragAndDrop : IDragAndDrop
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/drag_and_drop";
        private By heading = By.TagName("h3");

        public DragAndDrop()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public void DragDropAtoB(int id)
        {
            throw new NotImplementedException();
        }

        public void DragDropBtoA(int id)
        {
            throw new NotImplementedException();
        }

        public string getHeading()
        {
            return _browser.FindElement(heading).Text;
        }
        
    }
}
