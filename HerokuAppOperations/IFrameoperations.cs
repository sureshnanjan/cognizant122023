using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    interface IFrameoperations
    {
        /// <summary>
        /// This method  undoOperation() undoes the operations in the eiditor window
        /// </summary>
        void undoOperation();
        /// <summary>
        /// This method  redoOperation() redoes the operations in the eiditor window
        /// </summary>
        void redoOperation();
        /// <summary>
        /// This method  boldTextOperation() Bold the text in the eiditor window
        /// </summary>
        void boldTextOperation();
    }
}
