using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    ///<summery>
    ///This interface is created to validate the shift content.
    ///</summery>
    interface IShiftContent
    {
        ///<summery>
        ///This is to check Menu item page is opened
        ///</summery>
        ///<returns></returns>
        string getMenuItem();

        ///<summery>
        ///This is to check Image item page is opened
        ///</summery>
        ///<returns></returns>
        string getImageItem();

        ///<summery>
        ///This is to check List item page is opened
        ///</summery>
        ///<returns></returns>
        string getListpage();

        ///<summery>
        ///This is to check Menu loaded randomly or not
        ///</summery>
        ///<returns></returns>
        string loadMenuRandom();

        ///<summery>
        ///This is to check Menu shifted or not
        ///</summery>
        ///<returns></returns>
        string shiftMenuPixel();

        ///<summery>
        ///This is to check Menu loaded randomly and shifted or not
        ///</summery>
        ///<returns></returns>
        string loadMenuRandomAndShift();

        ///<summery>
        ///This is to check Image loaded randomly or not
        ///</summery>
        ///<returns></returns>
        string loadImageRandom();

        ///<summery>
        ///This is to check Image shifted or not
        ///</summery>
        ///<returns></returns>
        string shiftImagePixel();

        ///<summery>
        ///This is to check Image loaded randomly and shifted or not
        ///</summery>
        ///<returns></returns>
        string loadImageRandomAndShift();
    }
}
