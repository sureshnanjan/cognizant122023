using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  Handles the errors during application operation
    /// </summary>
    public interface IHerokuAppErrorHandler
    {
        /// <summary>
        /// Checks whether the current state is in Error
        /// </summary>
        /// <returns></returns>
        bool checkStatus();

        /// <summary>
        /// 
        /// </summary>
        void handleErrors();
    }
}
