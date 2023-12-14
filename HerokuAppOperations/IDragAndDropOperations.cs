using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    /// This interface is intended for the Drag And Drop sub page on horokuApp website.
    /// This will cover all the necessary operations and properties available on Drag And Drop sub page
    /// </summary>
    public interface IDragAndDropOperations
    {
        /// <summary>
        /// This will be used to get the heading of the sub page named as Drag and Drop. 
        /// here when user click and comes to DragandDrop page, he will see the heading as "Drag and Drop" only
        /// </summary>
        /// <returns>The return value is a string as the heading of the sub page is alphanumeric. 
        /// The expected value is as mentioned "Drag and Drop"</returns>
        string getHeading();

        /// <summary>
        /// The definition below will confirm when the sub page DragAndDrop is loaded successfully, user
        /// will see two objects named as A and B rectangles.
        /// </summary>
        /// <returns></returns>
        bool onPageLoadTwoObjectsSeen();
        /// <summary>
        /// On sub page load (i.e. Drag and Drop page), the two objects are seen.
        /// Try to select Block A and drag it and try to release on block B.
        /// This should be a success test case.
        /// </summary>
        /// <returns>The return value should be TRUE (boolean) if the block A is successfully 
        /// dragged and released on Block B.</returns>
        bool dragBlockA_dropOnBlockB();
        /// <summary>
        /// On sub page load (i.e. Drag and Drop page), the two objects are seen.
        /// Try to select Block B and drag it and try to release on block A.
        /// This should be a success test case.
        /// </summary>
        /// <returns>The return value should be string (Success/Fail) if the block B is successfully 
        /// dragged and released on Block A.</returns>
        string dragBlockB_dropOnBlockA();
        /// <summary>
        /// On sub page load (i.e. Drag and Drop page), the two objects are seen.
        /// Try to select Block A and drag it and try to release anywhere except on block B.
        /// This should be a failure test case. The Block A should go back to original position.
        /// </summary>
        /// <returns>The return value should be TRUE (boolean) if the block A is successfully 
        /// repositioned back to original position.</returns>
        bool dragBlockA_LeaveAnywhereToFail();
        /// <summary>
        /// On sub page load (i.e. Drag and Drop page), the two objects are seen.
        /// Try to select Block B and drag it and try to release anywhere except on block A.
        /// This should be a failure test case. The Block B should go back to original position.
        /// </summary>
        /// <returns>The return value should be TRUE (boolean) if the block B is successfully 
        /// repositioned back to original position.</returns>
        bool dragBlockB_LeaveAnywhereToFail();

    }
}
