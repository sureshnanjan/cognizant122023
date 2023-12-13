using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuAppScenarios
    {
        [Test]
        public void HomePageHas44Examples() {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            //int exampleCount = browser.FindElements(By.TagName("a")).Count;
            int excount = browser.FindElements(By.XPath("//*[@id='content']/ul/li")).Count;
            Assert.That(excount, Is.EqualTo(44));
        
        }
        [Test]
        public void HeadingHasCorrectText() {
        // It should have one single item to asssert
        }

        [Test]
        public void HeadingHasCorrectFont() { }

        [Test]
        public void HeadingHasCorrectPlacement() { }

        [Test]
        public void AddRemoveElementsPageAddOneElementWorks() {
            IWebDriver browser = new ChromeDriver();
            browser.Navigate().GoToUrl("https://the-internet.herokuapp.com/");
            // Navigate to Add Remove Elements
            browser.FindElement(By.LinkText("Add/Remove Elements")).Click();
            // Action to Add Elemsnt
            browser.FindElement(By.XPath("//*[@id='content']/div/button")).Click();
            // Assert that a new element got added
            int noofElemenstAdded = browser.FindElements(By.ClassName("added-manually")).Count;
            Assert.That(noofElemenstAdded, Is.EqualTo(1));


        }

        [Test]
        public void CheckShadowDOM() { }

        [Test]
        public void VerifyShiftingContent() { }
    }
}
