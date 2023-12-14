using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for the Sorted Data Table subpage for HerokuApp website.
    /// This will cover all the necessary operations and properties available on SortedDataTables sub page
    /// </summary>
    public interface ISortedDataTables
    {
        /// <summary>
        /// This will be used to get the heading of the sub page
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alphanumeric</returns>
        string getHeading();

        /// <summary>
        /// This is used when edit hyperlink is clicked on table row
        /// </summary>
        /// <returns></returns>
        void editRow();

        /// <summary>
        /// This is used when delete hyperlink is clicked on table row
        /// </summary>
        /// <returns></returns>
        void deleteRow();

        /// <summary>
        /// This is used to get data for the specified table
        /// </summary>
        /// <parameter>Type == "string" Name == "tableId"</parameter>
        /// <returns></returns>
        void getTableData(string tableId);

        /// <summary>
        /// This is used to get the total number of rows in specified table
        /// </summary>
        /// <parameter>Type == "string" Name == "tableId"</parameter>
        /// <returns>Type == "int" Description == "Gets Total number of rows in table"</returns>
        int getRowCount(string tableId);
    }
}
