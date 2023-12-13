using HerokuAppOperations;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuPages
{
    public class BrokenImagesPage : IBrokenImages
    {
        private IWebDriver _browser;
        private string _url = "https://the-internet.herokuapp.com/broken_images";
        private By headingLocator = By.TagName("h3");


        public BrokenImagesPage()
        {
            _browser = new ChromeDriver();
            _browser.Navigate().GoToUrl(_url);
        }

        public void uploadImage()
        {
            throw new NotImplementedException();
        }

        public void removeImage()
        {
            throw new NotImplementedException();
        }
        public int getUploadedImagesCount()
        {
            throw new NotImplementedException();
        }

    }
}
