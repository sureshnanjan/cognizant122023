using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuScenariosCleanDesign
    {
        private int myvar;
        private IHerokuApp app;
        private IHomePageOperations homePage;
        
        [OneTimeSetUp]
        public void InitializeApplication() {
            app = new HerokuApplication().getApplicationInstance();
            
        }

        [SetUp]
        public void beforeEachTest() {
            homePage = app.goToHome() as IHomePageOperations;
        }

        [Test]
        public void HomePageHas44Examples() {

            // AAA
            int nofoExamples = homePage.getExamplesCount();
            Assert.That(nofoExamples, Is.EqualTo(44));
        
        }

        [Test]
        public void HomePageHasCorrectHeadingText()
        {
            string headingString = app.getHeading();
            Assert.That(headingString, Is.EqualTo("Welcome to the-internet"));
            
        }

        [Test]
        public void HomePageHasCorrectSubHeadingText()
        {
            string subHeading = app.getSubHeading();
            Assert.That(subHeading, Is.EqualTo("Available Examples"));

        }

        [Test]
        public void HerokuAppAddingOneElementWorks() {
            var adrpage = homePage.goToExample("Add/Remove Elements") as IAddRemoveElements;
            adrpage.addElement();
            int available = adrpage.getAddedElemenstCount();
            Assert.That(available, Is.EqualTo(1));
            
        }
        [Test]
        public void HerokuAppFrames()
        {
            var adrpage = homePage.goToExample("Frames") as IFrames;
            string heading=adrpage.getheading();
                       
            Assert.That(heading, Is.EqualTo("Frames"));

        }

        [Test]
        public void HerokuAppAddingFiveElementWorks()
        {

            var adrpage = homePage.goToExample("Add/Remove Elements") as IAddRemoveElements;
            for (int i = 0; i < 5; i++)
            {
                adrpage.addElement();
            }
            int addedElements = adrpage.getAddedElemenstCount();
            Assert.That(addedElements, Is.EqualTo(5));
        }

        [Test]
        public void CheckNewDesignWorks() {

            Assert.That(app.getHeading(), Is.EqualTo("The Internet"));
            



        }
    }
}
