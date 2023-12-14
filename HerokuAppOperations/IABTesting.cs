using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for ABTesing sub page on HerokuApp Site
    /// </summary>
    interface IABTesting
    {
        /// <summary>
        /// This will be used to get the heading of the sub page named as ABTesting. 
        /// here when user click and comes to ABTesting page, he will see the heading as "A/B Testing" only
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alpha and Special symbol </returns>
        string getHeading();

       /// <summary>
       /// This will be used to get Contentlength of the Paragraph 
       /// </summary>
       /// <returns>This return value is an integer</returns>
        int getContentLength();

        /// <summary>
        /// This will be used to return content of the example Paragraph
        /// </summary>
        /// <returns>This return value is the string </returns>
        /// Expected result  (e.g. a user action such as a click-through)
        string returncontent();

        /// <summary>
        /// This will be used exit the Application 
        /// </summary>
        void exitApplication();
    }
}
