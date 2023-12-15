using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IJavaScriptOnloadEventError
    {
        /// <summary>
        /// If there is any JavaScript error, display the message
        /// </summary>
        /// <returns></returns>
        string getErrorMessage();
    }
}
