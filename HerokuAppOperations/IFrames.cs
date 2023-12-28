using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   public interface IFrames
    {/// <summary>
     /// this  getheading() method used to get the heading "Frames" and it will checks the condition Equalto
     /// </summary>
     /// <returns></returns>
        string getheading();
        /// <summary>
        /// This getItem() used to get the items in the window, Nested Frame & iFrames
        /// </summary>
        /// <returns></returns>
        void getItem();
        /// <summary>
        /// This goToExample() will navigate to IFrame & NestedFrame
        /// </summary>
        /// <returns></returns>
        string goToExample();
    }
}
