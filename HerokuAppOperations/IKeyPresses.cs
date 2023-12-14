using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IKeyPresses
    {
        /// <summary>
        /// get heading of Key Presses page
        /// </summary>
        /// <returns>Heading of Key Presses page</returns>
        string getHeading();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        String getEnteredText();

    }
}
