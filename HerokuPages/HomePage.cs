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
    public class HomePage : HerokuApplication, IHomePageOperations
    {

        private By examplesLocator;
        //private By subHeadingLocator;

        public HomePage(IWebDriver driver) : base(driver)
        {
            examplesLocator = By.XPath("//*[@id='content']/ul/li/a");
        }

        public int getExamplesCount()
        {
            return _browser.FindElements(examplesLocator).Count();
        }

        IHerokuApp IHomePageOperations.goToExample(string exampleName)
        {
            _browser.FindElement(By.LinkText(exampleName)).Click();
            switch (exampleName.Trim().ToLower())
            {
                case "add/remove elements":
                    return new AddRemoveElements(_browser);
                default:
                    return this;

            }
        }
    }
}
