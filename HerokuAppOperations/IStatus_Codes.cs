using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IStatus_Codes
    {
        string getHeading();
        int getStatusCodesCount();

       
        void goToStatusCodeCompleteList();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleName"></param>
        /// <returns></returns>
        IHerokuApp goToStatusCodes(string exampleName);


    }
}
