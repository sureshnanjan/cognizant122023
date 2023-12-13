using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IAddRemoveElements
    {
        string getHeading();
        void addElement();

        void removeElement();

        int getAddedElementsCount();
    }
}
