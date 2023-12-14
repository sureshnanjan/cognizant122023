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
        /// <returns></returns>
        String getHeading();

        /// <summary>
        /// after typing the key in the textbox,it will give what type of key you inputted. 
        /// </summary>
        /// <returns></returns>
        String getEnteredKeyText();
    }
}
