using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface INestedFrame
    {
        /// <summary>
        /// This method getFrameCounts() used to get the total number of frames in the Nested Frame
        /// </summary>
        /// <returns></returns>
        int getFrameCounts();
        /// <summary>
        /// This method getFrameTitle() used to get the titles of the frames Right,Left,Middle,Bottom
        /// </summary>
        /// <returns></returns>
        string getFrameTitle();
    }
}
