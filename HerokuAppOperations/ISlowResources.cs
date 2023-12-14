using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  Interface for Slow Resources Screen
    /// </summary>
   public interface ISlowResources
    {
        /// <summary>
        /// Get Sub Heading present in screen.
        /// </summary>
        /// <returns> returns sub heading content on the page</returns>
        string getSubHeading();



        /// <summary>
        /// Get Description present in screen
        /// </summary>
        /// <returns>return description present in screen</returns>
        string getDescription();



        /// <summary>
        /// Get Load Time
        /// </summary>
        /// <returns>returns Load time of screen</returns>
        int getLoadTime();

    }
}
