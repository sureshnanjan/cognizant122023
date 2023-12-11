using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHomePageOperations
    {
        string getHeading();
        string getSubHeading();
        void goToExample(string exampleName);

        int getExamplesCount();
        string getForkmeDetails();

        void exitApplication();
    }
}
