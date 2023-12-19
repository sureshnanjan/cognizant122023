using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;
using OpenQA.Selenium.Interactions;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuScenariosCleanDesign
    {
        [Test]
        public void HomePageHas44Examples() {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            int nofoExamples = page.getExamplesCount();
            Assert.That(nofoExamples, Is.EqualTo(44));
        
        }

        [Test]
        public void HomePageHasCorrectHeadingText()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string headingString = page.getHeading();
            Assert.That(headingString, Is.EqualTo("Welcome to the-internet"));
            page.exitApplication();

        }

        [Test]
        public void HomePageHasCorrectSubHeadingText()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string subHeading = page.getSubHeading();
            Assert.That(subHeading, Is.EqualTo("Available Examples"));

        }

        [Test]
        public void HerokuAppAddingOneElementWorks() {
            IAddRemoveElements page = null;
            page.addElement();
            int addedElements = page.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(1));
        }

        [Test]
        public void HerokuAppAddingFiveElementWorks()
        {
            IAddRemoveElements page = null;
            for (int i = 0; i < 5; i++)
            {
                page.addElement();
            }
            int addedElements = page.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(5));
        }

        [Test]
        [Category("ContextMenu")]
        [Author("Sonali")]
        public void ContextMenuHasCorrectHeadingText()
        {
            // AAA
            IContextMenu page = null;
            // Act
            page.clickonpagelink();
            string contextHeading = page.getHeadingOnClick();
            //Assert
            Assert.That(contextHeading, Is.EqualTo("Context Menu"));
            string alertHeading = page.GetBoxclicknalrt();
            Assert.That(contextHeading, Is.EqualTo("You selected a context menu"));

        }
        

    }
}
