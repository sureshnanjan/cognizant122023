using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// The interface to capture the project page related checks which is common across all individual pages
    /// </summary>
    public interface IProjectPageOperations
    {
        /// <summary>
        ///  Gets the Project external url
        /// </summary>
        /// <returns></returns>
        string getUrl();

    }
}
