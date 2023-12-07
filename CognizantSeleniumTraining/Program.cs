using System;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Edge;

namespace CognizantSeleniumTraining
{
    class Program
    {
        static void Main(string[] args)
        {
            string typeOfBrowser = "chrome";
            IWebDriver broswer;
            switch (typeOfBrowser)
            {
                case "chrome":
                    broswer = new ChromeDriver();
                    break;
                case "firefox":
                    broswer = new FirefoxDriver();
                    break;
                default:
                    broswer = new EdgeDriver();
                    break;
            }
        
            // Navigate to https://the-internet.herokuapp.com/
            INavigation objectReturned = broswer.Navigate();
            objectReturned.GoToUrl("https://the-internet.herokuapp.com/");
            // close the browser
            // Take a Screen Shot
            ITakesScreenshot mycamera = broswer as ITakesScreenshot;
            mycamera.GetScreenshot();
            IJavaScriptExecutor myscrriptengine = broswer as IJavaScriptExecutor;
            myscrriptengine.ExecuteScript("alert('This Message')");
            broswer.Quit();
            



            
            
            

        }
    }
}
