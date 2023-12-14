using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using HerokuAppOperations;

namespace HerokuPages
{
    public class CheckBoxStatus : ICheckboxCheckUncheck
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/checkboxes";
        System.Collections.ObjectModel.ReadOnlyCollection<IWebElement> checkboxes;
        private By checkbox = By.XPath("//input[@type='checkbox']");

        public CheckBoxStatus()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
            checkboxes = _browser.FindElements(checkbox);
        }
        public bool isBox1Checked()
        {
           return checkboxes[0].Selected;
        }

        public bool isBox2Checked()
        {
            return checkboxes[1].Selected;
        }
       
    }
}
