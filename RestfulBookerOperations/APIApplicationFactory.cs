using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestfulBookerOperations
{
    public class APIApplicationFactory
    {
        public static APIAutomationConfiguration getAPIEndPointParams() {
            var setting = readAppSettings();
            return new APIAutomationConfiguration(setting.url.Trim(),setting.port.Trim());
            
        }


        private static (string url,string port) readAppSettings() {
            var applicationSettings = ConfigurationManager.GetSection("APISettings") as NameValueCollection;
            if (applicationSettings.Count == 0)
            {
                Console.WriteLine("Application Settings are not defined");
                return (default,default);
            }
            else
            {
                return (applicationSettings["url"],applicationSettings["port"]);
            }
            
        
        }

        public static IRestfulBookerOperations getApplication()
        {
            APIAutomationConfiguration config = getAPIEndPointParams();
            throw new NotImplementedException();
        }
    }
}
