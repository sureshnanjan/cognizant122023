using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IWYSIWYGEditor
    {
        // Get the title
        string getHeading();

        // check the contentlength
        string getContentLength();

        // Get the count of Menubar
        string getMenuBarCount();

        // Open the Filemenu
        void fileElement();

        // Open the EditMenu
        void editElement();

        // Open the Viewmenu
        void viewElement();

        // Open the Formatmenu
        void formatElement();

        // Get the Statusbar
        string getStatusBarDetails();

        // Exit the Application
        void exitApplication();
    }
}
