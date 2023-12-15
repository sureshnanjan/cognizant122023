using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IGeoLocation
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getTitle();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getDescription();
        /// <summary>
        /// 
        /// </summary>
        void checkWhereIam();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getLatitude();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getLongitide();
        /// <summary>
        /// 
        /// </summary>
        void seeOnGoogle();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getLocationfromGoogleMaps();
    }
}
