using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// Interface for DOM Challenging Screen
    /// </summary>
   public interface IDOMChallengingOperation
    {

        /// <summary>
        /// Get Sub Heading present in screen
        /// </summary>
        /// <returns></returns>
        string getSubHeading();

        /// <summary>
        /// Get description present in the screen
        /// </summary>
        /// <returns></returns>
        string getDescription();

        /// <summary>
        ///Get Button Text on click
        /// </summary>
        void getButtondescription();

        /// <summary>
        /// Get Answer on button click
        /// </summary>
        void getAnswer();

        /// <summary>
        /// Get total buttons count
        /// </summary>
        void getButtonCount();

        /// <summary>
        /// Get all table elements
        /// </summary>
        /// <returns></returns>
        string getTableElements();

        /// <summary>
        /// Get all table Row count
        /// </summary>
        /// <returns>
        /// It returns table elements in string format
        /// </returns>
        string getTableRowCount();

        /// <summary>
        /// Perform edit of table element
        /// </summary>
        /// <param name="rowId"></param>
        void EditRow(int rowId);

        /// <summary>
        /// Perform Delete of table element
        /// </summary>
        /// <param name="rowId"></param>
        void HyperlinkDelete(int rowId);

    }
}
