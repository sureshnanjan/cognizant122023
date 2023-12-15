using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    class APIoperations
    {
        void doPost() {
            string url = "https://petstore.swagger.io/v2/user/createWithArray";
            string[] testusers = JsonUtilites.readFile("testusers.csv");

        }
        
    }
}
