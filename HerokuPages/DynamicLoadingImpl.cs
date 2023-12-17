using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HerokuAppOperations;
using OpenQA.Selenium;
using System.Threading;

namespace HerokuPages
{
    public class DynamicLoadingImpl:IDynamicLoading
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/dynamic_loading";
       
        public DynamicLoadingImpl()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public String DoExample1()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/a[1]")).Click();
            _browser.FindElement(By.XPath("//*[@id='start']/button")).Click();
            return _browser.FindElement(By.XPath("//*[@id='finish']/h4")).Text; 
        }

        public String  DoExample2()
        {
            throw new NotImplementedException();
        }

        public string getExample1Heading()
        {
          return  _browser.FindElement(By.XPath("//*[@id='content']/div/a[1]")).Text;

        }
          
        public string getExample1PageSubHeading()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/a[1]")).Click();
           return _browser.FindElement(By.XPath("//*[@id='content']/div/h4")).Text;
        }

        public string getExample2Heading()
        {
            return _browser.FindElement(By.XPath("//*[@id='content']/div/a[2]")).Text;

        }

        public string getExample2PageSubHeading()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/a[2]")).Click();
            Thread.Sleep(30000);
            return _browser.FindElement(By.XPath("//*[@id='content']/div/h4")).Text;
        }

        public string getForkmeDetails()
        {
            throw new NotImplementedException();
        }

        public string getHeading()
        {
             return _browser.FindElement(By.XPath("//*[@id='content']/div/h3")).Text;

        }

        public string getParagrapghText()
        {
            throw new NotImplementedException();
        }

        public void navigateExample1()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/a[1]")).Click();
        }

        public void navigateExample2()
        {
            _browser.FindElement(By.XPath("//*[@id='content']/div/a[2]")).Click();
        }
    }
}
