using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBrokenImages
    {
        string getHeading();

        bool isImageValid();

        int getBrokenImagesCount();

        int getTotalImagesCount();
    }
}
