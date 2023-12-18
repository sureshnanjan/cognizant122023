using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// An interface which implements the logic to obtain the Application instance
    /// to the consuming clients of the implementation
    /// </summary>
    public interface IAppFactory
    {
        /// <summary>
        /// This is the factory method Interface to obtain an Instance of the Application
        /// </summary>
        /// <returns></returns>
        IHerokuApp getApplicationInstance();
        
    }
}
