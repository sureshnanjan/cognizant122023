using HerokuAppOperations;
using NUnit.Framework;
using HerokuPages;
using System;

namespace ApplicationScenarios
{
    [TestFixture]
    class HerokuScenariosCleanDesign
    {
        //[SetUpFixture]
        public void BeforeSuiytExecition() { }
        [SetUp]
        public void setupMethod() {
            //
        }

        [TearDown]
        public void CleanUp() {
            // Brower close all running instance 
        }
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
        public void HerokuAppUploadFileHeadingIsCorrect()
        {
            // Arrange
            IFileUpload page = null;
            string expected = "File Uploader";
            // Act
            string actual = page.getHeading();

            // Assert 
            Assert.That(actual, Is.EqualTo(expected));
        }

        [Test]
        public void HerokuAppUploadFileWithNoEmptyFilename()
        {
            // Arrange
            IFileUpload page = null;
            page.uploadThroughChooseFile("");
            string status = page.getStatusMessage();
            // Assert 
            Assert.That(status , Is.EqualTo("Internal Server Error"));
        }

        [Test]
        public void HerokuAppUploadFileWithValidFilename()
        {
            // Arrange
            IFileUpload page = null;
            page.uploadThroughChooseFile(@"c:\tools\documents\mytestfile.txt");
            string status = page.getStatusMessage();
            // Assert 
            Assert.That(status, Is.EqualTo(@"mytestfile.txt"));
        }

        [Test]
        public void HerokuAppSlowResourceWith2GNetwork()
        {
            // Arrange
            ISlowResource  page = null;
            // Setup Network to 2g
            int expectedtime = 30;

            page.Load();
            int actualLoafTime = page.getLoadTime();
            
            // Setup network to 2G
            
        }

        [Test]
        public void SortableTablesHasCorrectNoOfRecords() {
            // Arrange
            ISortableTables page = null;
            //string[] expectedNames = CSVUtil.getData("fname");
            string[] names = page.GetCoumnData("fname");
            //Assert.That(names.Length, Is.EqualTo(expectedNames.Length));
        }

        [Test]
        public void SortableTablesHasCorrectSortingBehaviouronFname()
        {
            /*
            // Arrange
            ISortableTables page = null;
            //string[] expectedNames = CSVUtil.getData("fname");
            ///Array.Sort(expectedNames);
            // Act
            page.sort("fname");
            string[] names = page.GetCoumnData("fname");
            Assert.That(names.Length, Is.EqualTo(expectedNames.Length));
            Assert.That(names, Is.Ordered);
            */
        }
    }
}
