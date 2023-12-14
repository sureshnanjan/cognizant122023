using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{   
    public interface IShadowDom
    {   /// <summary>
        /// click on link and navigate to IsShadowDown
        /// </summary>
        void clickonShadowlink();
        /// <summary>
        /// get heading after click on option
        /// </summary>
        string getHeadingOnClick();
        /// <summary>
        /// get paragraph text available
        /// </summary>
        /// <returns></returns>
        string getParaText();
    }
}
