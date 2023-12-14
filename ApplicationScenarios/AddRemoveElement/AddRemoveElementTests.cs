using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;
using HerokuAppOperations.AddRemoveElements;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ApplicationScenarios.AddRemoveElement
{
    /// <summary>
    /// AddRemoveElementTests
    /// </summary>
    [TestFixture]
    public class AddRemoveElementTests
    {
        private IAddRemoveElement addRemoveElement;
        private IWebDriver _browser;

        /// <summary>
        /// Setup driver
        /// </summary>
        [SetUp]
        public void Setup()
        {

            _browser = new ChromeDriver();
            addRemoveElement = new AddRemoveElementData(_browser);
        }

        /// <summary>
        /// Get count of example listed on site
        /// </summary>
        [Test]
        public void HomePageHas44Examples()
        {
            addRemoveElement.OpenSite("https://the-internet.herokuapp.com/");

            // Act
            int nofoExamples = addRemoveElement.GetExamplesCount();
            Assert.That(nofoExamples, Is.EqualTo(44));
        }

        /// <summary>
        /// Get count of example listed on site
        /// </summary>
        [Test]
        public void AddRemoveSiteName()
        {
            addRemoveElement.OpenSite("https://the-internet.herokuapp.com/");

            // Act
            addRemoveElement.AddRemoveElementClickEvent("Add/Remove Elements");

            var name = addRemoveElement.GetSiteHeading(By.TagName("h3"));
            Assert.That(name, Is.EqualTo("Add/Remove Elements"));
        }

        /// <summary>
        /// Get count of example listed on site
        /// </summary>
        [Test]
        public void NumberOfAddedElement()
        {
            addRemoveElement.OpenSite("https://the-internet.herokuapp.com/");

            // Act
            addRemoveElement.AddRemoveElementClickEvent("Add/Remove Elements");

            addRemoveElement.AddElementClick();
            addRemoveElement.AddElementClick();

            int nofoButtons = addRemoveElement.CountOfDeleteButton();
            Assert.That(nofoButtons, Is.EqualTo(2));
        }
    }
}
