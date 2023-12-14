using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary> 
    /// Interface for Dyanamic Loading Page
    /// </summary>
    interface IDynamicLoading
    { 
        /// <summary>
        /// get heading of Dynamic Loading page
        /// </summary>
        /// <returns></returns>
        String getHeading();
        /// <summary>
        /// get result of Example1
        /// </summary>
        /// <returns></returns>
        String getExample1Result();
        /// <summary>
        /// get result of Example2
        /// </summary>
        /// <returns></returns>
        String getExample2Result();

        /// <summary>
        /// peform action on example1
        /// </summary>
        void DoExample1();

        /// <summary>
        /// perform action on example2
        /// </summary>
        void DoExample2();
        /// <summary>
        /// get fork me detials
        /// </summary>
        /// <returns></returns>
        string getForkmeDetails();


    }
}
