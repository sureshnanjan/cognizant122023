using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IEntryAd
    {
        /// <summary>
        /// Get username from home page, if available
        /// </summary>
        /// <returns></returns>
        string getUsername();

        /// <summary>
        /// Open pop-up window from main page
        /// </summary>
        /// <param name="username"></param>
        void openPopUp(string username);

        /// <summary>
        /// Close Pop-up window on 'close' button click
        /// </summary>
        void closePopUp();
        void enter();
        bool checkAdExists(string title);
        void closeAd();
        void reload();
        void reenableAd();
    }
}
