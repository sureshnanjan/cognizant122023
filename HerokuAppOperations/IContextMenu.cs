﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IContextMenu
    {   /// <summary>
        /// click on link and navigate to ContextMenu 
        /// </summary>
        void clickonpagelink();
        ///<summary>
        ///click on box and alert should be generated 
        ///</summary>
        /// <returns></returns>
        string GetBoxclicknalrt();
        
    }
}