using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IBasic_Auth
    {
        bool SuccessfullOnClickSign_in(string uname,string pass);
        bool OnClickCancel();
        bool InvalidOnClickSign_in(string uname,string pass);
        string BasicAuth_getHeading();
        string BasicAuth_getDescription();
        string getForkmeDetails();
    }
}
