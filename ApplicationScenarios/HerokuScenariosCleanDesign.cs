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

        [Test]
        [Author("Karthik")]
        [Category("Statuscode")]
        public void StatusCodeHasCorrectHeadingText()
        {
            var statuscodepage = homePage.goToExample("Status Codes") as IStatus_Codes;                       
            string statuscodeHeading = statuscodepage.getHeading();
            Assert.That(statuscodeHeading, Is.EqualTo("Status Codes"));
        }

        [Test]
        [Author("Karthik")]
        [Category("StatusCode")]
        public void StatusCodegetStatusCodesCount()
        {
            var statuscodePage = homePage.goToExample("Status Codes") as IStatus_Codes;
            int statuscodecount = statuscodePage.getStatusCodesCount();
            Assert.That(statuscodecount, Is.EqualTo(4));
        }

        [Test]
        [Author("Karthik")]
        [Category("StatusCode")]
        public void StatusCodegoToStatusCodes()
        {
            var statuscodePage = homePage.goToExample("Status Codes") as IStatus_Codes;
            statuscodePage.goToStatusCodes("200");
        }

        
        [Test]
        [Author("Karthik")]
        [Category("StatusCode")]
        public void ScodegoToStatusCodeCompleteList()
        {
            var statuscodePage = homePage.goToExample("Status Codes") as IStatus_Codes;
            statuscodePage.goToStatusCodes("200");
            statuscodePage.goToStatusCodeCompleteList();
        }

    }
}
