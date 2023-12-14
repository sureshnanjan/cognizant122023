﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace HerokuPages
{
    public class HomePage : IHomePageOperations
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
            //*[@id="content"]/ul/li[2]/a
            //*[@id="content"]/ul/li
            return _browser.FindElements(By.XPath("//*[@id='content']/ul/li")).Count;
        }

        public string getForkmeDetails()
        {
            
            return _browser.FindElement(By.XPath("/html/body/div[2]/a/img")).GetAttribute("alt");
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public string getSubHeading()
        {
            return _browser.FindElement(subHeadingLocator).Text;
        }

        public string goToExample(string exampleName)
        {
            return _browser.FindElement(By.LinkText(exampleName)).TagName;
        }

        private void CloseBrowser() {
            _browser.Quit();
        }

        public void exitApplication()
        {
            CloseBrowser();
        }
    }
}
