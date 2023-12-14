using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface ISortedDataTables
    {
        //Main heading for the Page
        string getHeading();

        //Hyperlink in table for Edit
        void editRow();

        //Hyperlink in table for Delete
        void deleteRow();

        //Get Data for specified table
        void getTableData(string table);

        //Get number of rows for specified table
        int getRowCount(string table);
    }
}
