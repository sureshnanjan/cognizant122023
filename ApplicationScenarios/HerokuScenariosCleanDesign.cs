using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuScenariosCleanDesign
    {
        private int myvar;
        [Test]
        public void HomePageHas44Examples() {

            int unused = 0;
            this.myvar = 100;
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
        public void HerokuAppCheckBox1ElementCheck()
        {
            ICheckboxCheckUncheck page = new CheckBoxStatus();
            bool box1Check = page.isBox1Checked();
            Assert.That(box1Check, Is.EqualTo(false));
            //bool box2Check = page.isBox2Checked();
            //Assert.That(box2Check, Is.EqualTo(true));
        }

        [Test]
        public void HerokuAppCheckBox2ElementCheck()
        {
            ICheckboxCheckUncheck page = new CheckBoxStatus();
            bool box2Check = page.isBox2Checked();
            Assert.That(box2Check, Is.EqualTo(true));            
        }
    }
}
