using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   public interface IInfiniteScroll
    {
        /// <summary>
        /// Get the heading to check equal or not
        /// </summary>
        /// <returns></returns>
        string getheading();
        /// <summary>
        /// Get the description to compare with the paragraph equal
        /// </summary>
        /// <returns></returns>
        string getDescription();
        /// <summary>
        /// when we scroll down , that scroll bar size gets decrease by this we can find the postion of the scroll bar
        /// </summary>
        /// <returns></returns>
        string ScrollBarPosition();
    }
}
