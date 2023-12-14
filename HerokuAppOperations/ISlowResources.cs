using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   public interface ISlowResources
    {
        //Get Sub Heading present in screen
        string getSubHeading();

        //Get Description present in screen
        string getDescription();

        //Get Load Time
        int getLoadTime();

    }
}
