using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IKeyPressses
    {
        /// <summary>
        /// get heading of Key Presses Loading page
        /// </summary>
        /// <returns>Heading of Key Presses page</returns>
        String getHeading();

        /// <summary>
        /// get the input key 
        /// </summary>
        /// <returns></returns>
        String getEnteredKeyText();
    }
}
