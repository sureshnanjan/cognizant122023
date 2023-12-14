using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary> 
    /// Interface for Dyanamic Loading Page and Example links available
    /// </summary>
    interface IDynamicLoading
    { 
        /// <summary>
        /// get heading of Dynamic Loading page
        /// </summary>
        /// <returns></returns>
        String getHeading();
        
        /// <summary>
        ///get the text of Paragraph of Dynamic Loading main page
        /// </summary>
        String getParagrapghText();
        /// <summary>
        ///After clicking on Example1 link we will be redirected to new page.
        /// </summary>
        /// <returns>return the sub heading of example 1 page</returns>
        String getExample1PageSubHeading();
        /// <summary>
        ///After clicking on Example2 link we will be redirected to new page.
        /// </summary>
        /// <returns>return the sub heading of example 2 page</returns>
        String getExample2PageSubHeading();

        /// <summary>
        /// After clicking on start button on Example1 page it will load the text
        /// </summary>
        ///<returns>return the text after loading it</returns>
        void DoExample1();

        /// <summary>
        /// After clicking on start button on Example2 page it will load the text
        /// </summary>
        ///<returns>return the text after loading it</returns>
        void DoExample2();

        /// <summary>
        /// get fork me detials
        /// </summary>
        /// <returns></returns>
        string getForkmeDetails();


    }
}
