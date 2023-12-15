using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IHovers
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getTitle();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getDescription();

        int getImagesCount();

        /// <summary>
        /// This will focus on the image with position.
        /// If 0 none of the image is selected
        /// </summary>
        /// <param name="position">Take a vlue from 0  to 3, If 0 No focus in on any Image</param>
        void hovertoImage(int position);
        /// <summary>
        /// Fetchess the USername and View Prfile link for the curretly active image
        /// </summary>
        /// <returns></returns>
        string getAdditionalInfo();

        void visitProfile();
    }
}
