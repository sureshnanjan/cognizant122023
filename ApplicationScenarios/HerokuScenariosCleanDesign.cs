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
            //page.exitApplication();

        }

        [Test]
        public void HomePageHasCorrectForkMe()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string forkMe = page.getForkmeDetails();
            Assert.That(forkMe, Is.EqualTo("Fork me on GitHub"));
            page.exitApplication();

        }

        [Test]
        public void HomePageHasGoToExample()
        {
            // AAA
            IHomePageOperations page = new HomePage();
            // Act
            string goToExample = page.goToExample("Add/Remove Elements");
            Assert.That("a", Is.EqualTo(goToExample));
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
        public void AddRemoveHasCorrectHeadingText()
        {
            // AAA
            IAddRemoveElements page = new AddRemoveElementsPage();
            // Act
            string heading = page.getHeading();
            Assert.That(heading, Is.EqualTo("Add/Remove Elements"));

        }

        [Test]
        public void AddRemoveHasCorrectAddElement()
        {
            // AAA
            IAddRemoveElements page = new AddRemoveElementsPage();
            // Act
            page.addElement();
            int addElements = page.getAddedElemenstCount();
            Assert.That(addElements, Is.EqualTo(1));

        }

        [Test]
        public void AddRemoveHasCorrectAddElementCount()
        {
            // AAA
            IAddRemoveElements page = new AddRemoveElementsPage();
            // Act
            page.addElement();
            int addElements = page.getAddedElemenstCount();
            Assert.That(addElements, Is.EqualTo(1));

        }

        [Test]
        public void AddRemoveHasCorrectRemoveElementCount()
        {
            // AAA
            IAddRemoveElements page = new AddRemoveElementsPage();
            // Act
            page.addElement();
            page.removeElement();
            int addElements = page.getAddedElemenstCount();
            Assert.That(addElements, Is.EqualTo(1));

        }

        [Test]
        public void DragAndDropHasCorrectHeadingText()
        {
            // AAA
            IDragAndDrop page = new DragAndDrop();
            // Act
            string heading = page.getHeading();
            Assert.That(heading, Is.EqualTo("Drag and Drop"));

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

    }
}
