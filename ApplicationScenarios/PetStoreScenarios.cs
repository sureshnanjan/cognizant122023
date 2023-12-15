using NUnit.Framework;

namespace ApplicationScenarios
{
    [TestFixture]
    [Category("PetStore")]
    [Author("Suresh Nanjan")]
    class PetStoreScenarios
    {
        [SetUp]
        public void doBeforeTest() { }

        [TearDown]
        public void doAfterTest() { }

        [Test]
        [Author("Suresh")]
        [Category("Petstore UI")]
        [Category("SmokeTest")]
        void petStoreHomePageLoadCorrectCategories() {
            // Arrange
            IPetStoreHome page = null;
            IAdminInteface adpage = null;
            page.dologin("teja", "pass");
            string[] approved = adpage.getApprovedItems();
            // MAke a DB Call to get all approved items 
            // API Call to get all approved items https://petstore.swagger.io/v2/pet/findByStatus?status=available
            page.CheckCategories(approved.Length);
        
        }



    }
    [SetUpFixture]
    class SetupPetstore {

        public void CreateUserforApp() {
            // 
        }
    
    
    }
    
}

