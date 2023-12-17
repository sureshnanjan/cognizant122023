using NUnit.Framework;
using HerokuAppOperations;
using System;
using HerokuPages;

namespace ApplicationScenarios
{
    [TestFixture]
    class DynamicLoadingScenarios
    {
        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void DynamicLoadingHeading()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String  dynamicPageHeading =page.getHeading();
            // Assert
            Assert.That(dynamicPageHeading, Is.EqualTo("Dynamically Loaded Page Elements"));
        }

        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void Example1Textverify()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String dynamicPageHeading = page.getExample1Heading();
            // Assert
            Assert.That(dynamicPageHeading, Is.EqualTo("Example 1: Element on page that is hidden"));
        }

        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void Example2Textverify()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String dynamicPageHeading = page.getExample2Heading();
            // Assert
            Assert.That(dynamicPageHeading, Is.EqualTo("Example 2: Element rendered after the fact"));
        }
        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void Example1PageSubHeadingVerify()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String dynamicPageHeading = page.getExample1PageSubHeading();
            // Assert
            Assert.That(dynamicPageHeading, Is.EqualTo("Example 1: Element on page that is hidden"));
        }

        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void Example2PageSubHeadingVerify()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String dynamicPageHeading = page.getExample2PageSubHeading();
            // Assert
            Assert.That(dynamicPageHeading, Is.EqualTo("Example 2: Element rendered after the fact"));
        }

        [Test]
        [Author("Ankit Sahu")]
        [Category("Dynamic Loading")]
        public void Example1DyanamicLoadingVerify()
        {
            //Arrange
            IDynamicLoading page = new DynamicLoadingImpl();
            //Act
            String starttext=page.DoExample1();
            // Assert
            Assert.That(starttext, Is.EqualTo("Hello World!"));
        }
    }
}
