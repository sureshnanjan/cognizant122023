using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IBrokenImages
    {
        //Get main heading for the page
        string getHeading();

        //Verify if Image is broken or not
        bool isImageValid();

        //Get number of broken image
        int getBrokenImagesCount();

        //Get total image count in page
        int getTotalImagesCount();
    }
}
