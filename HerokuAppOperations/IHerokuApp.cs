using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// 
    /// </summary>
    public interface IHerokuApp: IProjectPageOperations, IFooterPageOperations, IHerokuAppErrorHandler, IAppFactory, IHeadingOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IHerokuApp goToHome();

        /// <summary>
        /// 
        /// </summary>
        void exitApplication();


    }
}
