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
        public void HomePageForkmeDetails()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string ForkmeDetails = page.getForkmeDetails();
            Assert.That(ForkmeDetails, Is.EqualTo("Fork me on GitHub"));

        }

        [Test]
        public void HomePagegoToExample()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string toexp = "A/B Testing";
            string toExample = page.goToExample(toexp);
            Assert.That("a", Is.EqualTo(toExample));

        }


        [Test]
        public void AddRemoveHasCorrectHeadingText()
        {
            // AAA
            IAddRemoveElements page = new AddRemoveElementsPage();
           // Act
            string headingString = page.getHeading();
            Assert.That(headingString, Is.EqualTo("Add/Remove Elements"));
            page.exitApplication();

        }

        [Test]
        public void HerokuAppAddingOneElementWorks() {
            IAddRemoveElements page = new AddRemoveElementsPage();
            page.addElement();
            int addedElements = page.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(1));
            page.exitApplication();
        }

        [Test]
        public void HerokuAppAddingFiveElementWorks()
        {
            IAddRemoveElements page = new AddRemoveElementsPage(); 
            for (int i = 0; i < 5; i++)
            {
                page.addElement();
            }
            int addedElements = page.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(5));
        }


    }
}
