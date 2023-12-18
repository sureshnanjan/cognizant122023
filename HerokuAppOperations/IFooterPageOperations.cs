using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IFooterPageOperations
    {
        /// <summary>
        /// Gets the text displayed at the footer for each page on Heroku App
        /// </summary>
        /// <returns></returns>
        string getFooterText();
        /// <summary>
        /// Gets the Link displayed at the footer for each page on Heroku App
        /// </summary>
        /// <returns></returns>
        string getFooterLink();
    }
}
