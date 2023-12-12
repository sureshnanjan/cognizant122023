using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface captures all the operation possible on the Heroku Home Page
    /// </summary>
    public interface IHomePageOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getHeading();
        string getSubHeading();
        void goToExample(string exampleName);

        int getExamplesCount();
        string getForkmeDetails();

        /// <summary>
        /// 
        /// </summary>
        void exitApplication();

        
    }
}
