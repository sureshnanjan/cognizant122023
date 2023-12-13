﻿using HerokuAppOperations;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class AddRemoveElementsPage : IAddRemoveElements
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/add_remove_elements/";
        private By headingLocator = By.TagName("h3");


        public AddRemoveElementsPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public string getHeading()
        {
            return _browser.FindElement(headingLocator).Text;
        }

        public void addElement()
        {
            throw new NotImplementedException();
        }

        public void removeElement()
        {
            throw new NotImplementedException();
        }

        public int getAddedElementsCount()
        {
            throw new NotImplementedException();
        }
    }

}
