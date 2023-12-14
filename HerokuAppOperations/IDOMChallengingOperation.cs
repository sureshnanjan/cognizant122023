using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
   public interface IDOMChallengingOperation
    {
        //Get Sub Heading present in screen
        string getSubHeading();

        //Get description present in the screen
        string getDescription();

        //Get Button Text on click
        void getButtondescription();

        //Get Answer on button click
        void getAnswer();

        //Get total buttons count
        void getButtonCount();

        //Get all table elements 
        string getTableElements();

        //Get all table Row count
        string getTableRowCount();

        //Perform edit of table element
        void EditRow(int rowId);

        //Perform Delete of table element
        void HyperlinkDelete(int rowId);

    }
}
