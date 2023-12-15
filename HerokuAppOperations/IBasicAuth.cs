using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBasicAuth
    {
        // To get Dialog Box
        bool getDialogBox();

        // On Successfull Login
        bool onClickSuccessfullLogin(string uname, string pass);

        // If user gives empty user credentials
        bool onclickEmptyCredentialsLogin(string uname, string pass);

        // If user clicks cancel
        bool onClickCancel();

        // To get the heading
        string getHeading();

        // To get the description
        string getDescription();
    }
}
