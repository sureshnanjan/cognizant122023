﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface captures all the operation possible on the Heroku Home Page
    /// </summary>
    public interface IHomePageOperations
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="exampleName"></param>
        /// <returns></returns>
        IHerokuApp goToExample(string exampleName);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        int getExamplesCount();
        
        
    }
}
