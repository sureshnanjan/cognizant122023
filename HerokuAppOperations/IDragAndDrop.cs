using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerokuAppOperations
{
    public interface IDragAndDrop
    {
        //get heading of the page name
        string getHeading();

        //Drag and Drop A to B
        void DragDropAtoB(int id);

        //Drag and Drop B to A
        void DragDropBtoA(int id);

    }
}
