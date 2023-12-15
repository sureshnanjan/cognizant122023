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
    public interface INestedFrames
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int getFramesCount();
        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        void goToFrame(string position);

        string getTitleFromFrame();

        int getWidthFromFrame();
    }
}
