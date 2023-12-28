using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ISlowResources
    {
        // To get the heading
        string getHeading();

        // To get the description
        string getDescription();

        //To get Time Request
        int getLoadTime();

        void Load();
    }
}
