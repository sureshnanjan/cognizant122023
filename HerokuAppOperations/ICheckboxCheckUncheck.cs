using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    ///<summery> 
    ///This interface is created for Heroko operations to perform validation checks on check box.
    ///</summery>

    public interface ICheckboxCheckUncheck
    {
        ///<summery>
        ///This method is to check the first check box checked or not
        ///</summery>
        ///<returns>returns the check box status</returns>
        bool isBox1Checked();

        ///<summery>
        ///This method is to check the second check box checked or not
        ///</summery>
        ///<returns>returns the check box status</returns>
        bool isBox2Checked();

        ///<summery>
        ///This method is to check the fisrt check box unchecked or not
        ///</summery>
        ///<returns>returns the check box status</returns>
        bool isBox1Unchecked();

        ///<summery>
        ///This method is to check the second check box unchecked or not
        ///</summery>
        ///<returns>returns the check box status</returns>
        bool isBox2Unchecked();
    }
}
