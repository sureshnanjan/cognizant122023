using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IStatus_Codes
    {
        string getHeading();
        string getDescription();
        string getForkmeDetails();
        int getStatusCodesCount();
        string OnClickCompleteListOfStatusCodes();
        void goToStatusCodes(string statusCode);
    }
}
