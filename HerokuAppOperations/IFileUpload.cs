using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IFileUpload
    {
        string getHeading();
        string getDescription();

        string getStatusMessage();

        void uploadThroughChooseFile(string pathtofile);
        void uploadThroughDragDrop(string pathtoFile);
    }
}
