using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for WYSIWYGEditor sub page on HerokuApp Site
    /// </summary>
    interface IWYSIWYGEditor
    {

        /// <summary>
        /// This will be used to get the heading of the sub page named as WYSIWYGEditor. 
        /// here when user click and comes to WYSIWYGEditor page, he will see the heading as "An iFrame containing the TinyMCE WYSIWYG Editor" only
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alpha </returns>
        string getHeading();

        /// <summary>
        /// This will be used to get Contentlength of the Paragraph 
        /// </summary>
        /// <returns>This return value is an integer</returns>
        int getContentLength();

        /// <summary>
        /// This will be used to get the count of the Menubar
        /// </summary>
        /// <returns>This return value is an integer</returns>
        int getMenuBarCount();

        /// <summary>
        /// This will be used create the new document 
        /// </summary>
        void createDocument();

        /// <summary>
        /// This will be used to check the string empty or not
        /// </summary>
        /// <returns>This return value is string</returns>
        string getcheckEmptycontent();


        /// <summary>
        /// This will be used getcontent details
        /// </summary>
        /// <returns>This return value is string</returns>
        string getContent();

        /// <summary>
        /// This will be used undo document 
        /// </summary>
        /// <returns></returns>
        string undoDocument();

        /// <summary>
        /// This will be used redo document 
        /// </summary>
        /// <returns></returns>
        string redoDocument();


        /// <summary>
        /// This will be used to get the Statusbar data
        /// </summary>
        /// <returns>This return value is a string</returns>
        /// expected result - (Powered by Tiny)
        string getStatusBarDetails();

        /// <summary>
        /// This will be used to exit Application
        /// </summary>
        void exitApplication();
    }
}
