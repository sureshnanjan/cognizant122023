using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    //This interface is created to validate the shift content.
    interface IShiftContent
    {
        //This is to check Menu item page is opened
        string getMenuItem();

        //This is to check Image item page is opened
        string getImageItem();

        //This is to check List item page is opened
        string getListpage();

        //This is to check Menu loaded randomly or not
        string loadMenuRandom();

        //This is to check Menu shifted or not
        string shiftMenuPixel();

        //This is to check Menu loaded randomly and shifted or not
        string loadMenuRandomAndShift();

        //This is to check Image loaded randomly or not
        string loadImageRandom();

        //This is to check Image shifted or not
        string shiftImagePixel();

        //This is to check Image loaded randomly and shifted or not
        string loadImageRandomAndShift();
    }
}
