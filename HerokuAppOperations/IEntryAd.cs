using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IEntryAd
    {
        //Get the heading of the page
        string getHeading();

        //popup will show when the page loads
        void modelPopupWindowShowAfterLoadingThePage();

        //popup to close
        void modelPopupWindowClose();

        //to open the popup when we click on the link/button
         void toShowPopupWindow(int id);

    }
}
