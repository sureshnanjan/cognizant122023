using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    ///<summery> 
    ///This interface is created for Heroko operations to perform validations checks on check box.
    ///</summery>

    public interface ICheckboxCheckUncheck
    {
        ///<summery>
        ///This method is to check the first check box status
        ///</summery>
        ///<returns></returns>
        bool isBox1Checked();

        ///<summery>
        ///This method is to check the second check box status
        ///</summery>
        ///<returns></returns>
        bool isBox2Checked();        
    }
}
