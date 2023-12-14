using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for the Broken Images subpage for HerokuApp website.
    /// This will cover all the necessary operations and properties available on BrokenImages sub page
    /// </summary>
    public interface IBrokenImages
    {

        /// <summary>
        /// This will be used to get the heading of the sub page
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alphanumeric</returns>
        string getHeading();


        /// <summary>
        /// This will be used to verify if the image is valid or broken 
        /// </summary>
        /// <parameter></parameter>
        /// <returns>Type == "bool" Description == "Return true in case image is valid else false when image is broken"</returns>
        bool isImageValid(string imageElement);


        /// <summary>
        /// This will be used to get the count of broken images
        /// </summary>
        /// <returns>Type == "int" Description == "Total number of Broken Images"</returns>
        int getBrokenImagesCount();

        /// <summary>
        /// This will be used to get the count of images
        /// </summary>
        /// <returns>Type == "int" Description == "Total number of Images"</returns>
        int getTotalImagesCount();
    }
}
