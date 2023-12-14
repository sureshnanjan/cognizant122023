using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;

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
            page.exitApplication();
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
            page.exitApplication();
        }

        [Test]
        public void HomePageClickforkMedetails()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string forkMeDetails = page.getForkmeDetails();
            Assert.That(forkMeDetails, Is.EqualTo("https://github.com/saucelabs/the-internet"));
            page.exitApplication();
        }

        [Test]
        public void HerokuAppAddingOneElementWorks() {
            IAddRemoveElements page = null;
            page.addElement();
            int addedElements = page.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(1));
            page.exitApplication();
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
    }
}
