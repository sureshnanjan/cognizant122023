using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
  public  interface IFloatingMenu
    {
        /// <summary>
        /// Get the heading to check text is equal or not
        /// </summary>
        /// <returns></returns>
        string getheading();

        string getForkmeDetails();
        /// <summary>
        /// 4 floating menu's are available , to get this menu count
        /// </summary>
        /// <returns></returns>
        int getFloatMenuCount();
        /// <summary>
        /// scroll down and check floating menu is still visible
        /// </summary>
        /// <returns></returns>
        string Scrolldown();
        /// <summary>
        /// scroll up and check floating menu is still visible
        /// </summary>
        /// <returns></returns>
        string ScrollUp();
    }
}
