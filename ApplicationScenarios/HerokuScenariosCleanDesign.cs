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


        ///<summary>
        /// This test verifies the correct heading 
        ///</summary>
       [Test]
       [Category("Slow Resources")]
       [Author("Arnab")]
       public void SlowResourcesHasCorrectHeadingText()
        {
            string headingString = app.getHeading();
            Assert.That(headingString, Is.EqualTo("Slow Resources"));
        }

        /// <summary>
        /// To verify Loading Time in 2G Network
        /// </summary>
        [Test]
        public void SlowResourcesWith2GNwetwork()
        {
            //Arrange
            ISlowResources page = null;

            // Setup Network to 2g
            int expectedTime = 30;

            page.Load();

            int actualLoadTime = page.getLoadTime();

            Assert.That(actualLoadTime, Is.LessThanOrEqualTo(expectedTime));
        }
        /// <summary>
        /// To verify Loading Time in 3G Network
        /// </summary>
        [Test]
        public void SlowResourcesWith3GNwetwork()
        {
            //Arrange
            ISlowResources page = null;

            // Setup Network to 3g
            int expectedTime = 10;

            page.Load();

            int actualLoadTime = page.getLoadTime();

            Assert.That(actualLoadTime, Is.LessThanOrEqualTo(expectedTime));
        }
    }
}
