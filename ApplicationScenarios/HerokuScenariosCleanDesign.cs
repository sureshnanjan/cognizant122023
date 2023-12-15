using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuScenariosCleanDesign
    {
        [Test]
        public void HomePageHas44Examples()
        {
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
        public void HerokuAppAddingOneElementWorks()
        {
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
        [Author("Tejaswini")]
        [Category("AddEntry")]
        public void HerokuAppLoadsAdOnEntry()
        {
            IEntryAd page = null;
            page.enter();
            bool adExists = page.checkAdExists("This is a modal window");

            page.closeAd();
            Assert.That(adExists, Is.True);

        }

        [Test]
        [Author("Tejaswini")]
        [Category("AddEntry")]
        public void HerokuAppNoLoadOnReentry()
        {
            IEntryAd page = null;
            page.enter();
            page.closeAd();
            page.reload();
            bool adExists = page.checkAdExists("This is a modal window");
            Assert.That(adExists, Is.False);
        }

        [Test]
        [Author("Tejaswini")]
        [Category("AddEntry")]
        public void HerokuAppReenablingAdLoadDisplaysAd()
        {
            //Arrange
            IEntryAd page = null;
            page.enter();
            page.closeAd();
            page.reload();
            //Action
            page.reenableAd();
            page.reload();
            //Assertion
            bool adExists = page.checkAdExists("This is a modal window");
            Assert.That(adExists, Is.True);

        }

        //validate Title
    }
}
