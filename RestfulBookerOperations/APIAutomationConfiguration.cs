using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulBookerOperations
{
    public struct APIAutomationConfiguration
    {
        private string url;
        private string port;
        public APIAutomationConfiguration(string url, string port = default)
        {
            this.url = url;
            this.port = port;
        }
        
        public string Url
        {
            get { return url; }
            
        }

        

        public string Port
        {
            get { return port; }
            
        }


    }
}
