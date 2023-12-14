using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IExitIntent
    {

        /// <summary>
        /// Grabbing the Main heading text
        /// </summary>
        /// <returns></returns>
        /// 
        string ExitIntendPageHeading();


        /// <summary>
        /// Grabbing the sub heading text
        /// </summary>
        /// <returns></returns>
        string ExitIntendsubHeading();


        /// <summary>
        /// verify popupwindow display after moved to exit intent page 
        /// </summary>
        void VerifyPopupwindowprompting();


        /// <summary>
        ///Grabbing the text from the pop window
        /// </summary>
        /// <returns></returns>
        string gettingwindowtext();

        /// <summary>
        /// click the clode button verify the pop should be disaapeared
        /// </summary>

        void closewindow();

    }
}
