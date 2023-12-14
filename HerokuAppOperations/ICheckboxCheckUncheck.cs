using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    //This interface is created for Heroko operations to perform validations checks on check box.
    public interface ICheckboxCheckUncheck
    {
        //This method is to check the first check box status
        bool isBox1Checked();
        //This method is to check the second check box status
        bool isBox2Checked();        
    }
}
