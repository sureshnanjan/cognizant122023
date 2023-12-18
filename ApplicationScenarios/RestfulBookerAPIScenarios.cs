using RestfulBookerOperations;
using NUnit.Framework;
namespace ApplicationScenarios
{
    /// <summary>
    /// 
    /// </summary>
     
    [TestFixture]
    public class RestfulBookerAPIScenarios
    {
        /// <summary>
        /// 
        /// </summary>
        private static string api_token;
        /// <summary>
        /// 
        /// </summary>
        [OneTimeSetUp]
        public void prepareApplication() { 
        
        }
        /// <summary>
        /// 
        /// </summary>
        [Test]
        public void authenticationRequestReturnsToken() { }

        /// <summary>
        /// The Test to read the app settings are working OK. The API end points are set in the App.config file under the  
        /// APISettings section.
        /// </summary>
        [Test]
        public void appsettingsareReadOK() {
            APIAutomationConfiguration settings = APIApplicationFactory.getAPIEndPointParams();
            Assert.That(settings.Url.Contains("restful"), Is.True);
            //Assert.That(settings.Url.Contains("restful"), Is.False);

        }
    }
}
