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
        ///This method is to check Menu item page is opened
        ///</summery>
        ///<returns>returns the menu page header to check the menu page opened or not</returns>
        string getMenuItem();

        ///<summery>
        ///This method is to check Image item page is opened
        ///</summery>
        ///<returns>returns the image page header to check the page opened or not</returns>
        string getImageItem();

        ///<summery>
        ///This method is to check List item page is opened
        ///</summery>
        ///<returns>returns the List page header to check the page opened or not</returns>
        string getListpage();

        ///<summery>
        ///This method is to check Menu loaded randomly or not
        ///</summery>
        ///<returns>returns the position of the menu to check menu loaded randomly or not</returns>
        string loadMenuRandom();

        ///<summery>
        ///This method is to check Menu shifted or not
        ///</summery>
        ///<returns>returns the position of the menu to check menu shifted pixel or not</returns>
        string shiftMenuPixel();

        ///<summery>
        ///This method is to check Menu loaded randomly and shifted or not
        ///</summery>
        ///<returns>returns the position of the menu to check menu loaded randomly and shifted pixel or not</returns>
        string loadMenuRandomAndShift();

        ///<summery>
        ///This method is to check Image loaded randomly or not
        ///</summery>
        ///<returns>returns the position of the Image to check image loaded randomly or not</returns>
        string loadImageRandom();

        ///<summery>
        ///This method is to check Image shifted or not
        ///</summery>
        ///<returns>returns the position of the Image to check Image shifted pixel or not</returns>
        string shiftImagePixel();

        ///<summery>
        ///This method is to check Image loaded randomly and shifted or not
        ///</summery>
        ///<returns>returns the position of the Image to check Image loaded randomly and shifted pixel or not</returns>
        string loadImageRandomAndShift();
    }
}
