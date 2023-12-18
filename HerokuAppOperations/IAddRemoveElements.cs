using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    /// <summary>
    ///  This interface encapsulates all the Operations on the Add Remove Elements Page / Screen
    /// </summary>
    public interface IAddRemoveElements
    {
        /// <summary>
        ///  Adds a new element to the application
        /// </summary>
        void addElement();

        /// <summary>
        ///  Removes the first element from the added elements collection. 
        /// </summary>
        void removeElement();

        /// <summary>
        ///  Get the count of the available newli added element in teh application
        /// </summary>
        /// <returns></returns>
        int getAddedElemenstCount();
    }
}
