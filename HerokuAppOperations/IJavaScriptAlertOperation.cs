using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   public  interface IJavaScriptAlertOperation
    {
        /// <summary>
        /// Grabing the text from heading 
        /// </summary>
        /// <returns></returns>
        string gettingpageheading();

        /// <summary>
        /// click the JSAlert button and check pop-up windows is opening 
        /// close the pop up window verify windows is closing 
        /// </summary>
        void verifyJsAlertfunction();
        /// <summary>
        /// click the Jsconfirm button and check pop-up windows is opening 
        /// close the pop up window verify windows is closing
        /// </summary>
        void verifyJsConfirmfunction();

        /// <summary>
        /// click the Jsprompt button and check pop-up windows is opening 
        /// close the pop up window verify windows is closing
        /// </summary>
        
        void verifyJspromptfunction();

        /// <summary>
        /// open each js alert button function pop-up window grabbing the text from window 
        /// </summary>
        /// <returns></returns>
        string gettextfromjswindow();

        /// <summary>
        /// open each js alert button function pop-up window which has cancel function
        /// check cance function working 
        /// </summary>
        void cancelJSwindow();

        /// <summary>
        /// open js alert function 
        /// send the text to the text field 
        /// </summary>
        void entertextintojswindow();


        /// <summary>
        /// Click the each js alert function grabbing the text which is displayed under the resut section 
        /// </summary>
        /// <returns></returns>
        string getresult();




    }
}
