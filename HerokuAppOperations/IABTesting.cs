using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IABTesting
    {
        // Get the Title
        string getHeading();

        // Check the Contentlength
        string getContentLength();

        // Get the useraction
        void userAction();

        // Exit the application
        void exitApplication();
    }
}
