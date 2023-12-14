using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IShiftContent
    {
        string getMenuItem();

        string getImageItem();

        string getListpage();

        string loadMenuRandom();

        string shiftMenuPixel();

        string loadMenuRandomAndShift();

        string loadImageRandom();

        string shiftImagePixel();

        string loadImageRandomAndShift();
    }
}
