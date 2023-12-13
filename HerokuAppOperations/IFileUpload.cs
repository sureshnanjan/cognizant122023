using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IFileUpload
    {
        /// <summary>
        /// For getting the heading of the page
        /// </summary>
        /// <returns></returns>
        string getHeading();
        /// <summary>
        /// For getting the paragraph description of the page
        /// </summary>
        /// <returns></returns>
        string getDescription();
        /// <summary>
        /// For getting status message after uploading the file
        /// </summary>
        /// <returns></returns>
        string getStatusMessage();
        /// <summary>
        /// For uploading the file through chose file (file upload control)
        /// </summary>
        /// <param name="pathToFile"></param>
        void uploadThroughChooseFile(string pathToFile);
        /// <summary>
        /// For uploading the file through drag and drop
        /// </summary>
        /// <param name="pathToFile"></param>
        void uploadThroughDragDrop(string pathToFile);
        /// <summary>
        /// for closing the page
        /// </summary>
        void exitApplication();
    }
}
