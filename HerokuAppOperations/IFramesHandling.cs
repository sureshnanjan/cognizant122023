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
    public interface IFramesHandling
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getTitle();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        INestedFrames OpenNestedFrame();
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        ITinyEditor OpenIFrame();
    }
}
