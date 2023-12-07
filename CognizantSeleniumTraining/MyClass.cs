using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CognizantSeleniumTraining
{
    class MyClass :  ICalculate
    {
        // Members
        int noofParticpants;

        public int Calculate()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }

        public void ShowMembers() {
            Console.WriteLine($"{noofParticpants} number of people here");
        }
    }
    // Inheriatnce
    class mySpecialClass : MyClass {
        string typeoofclass;

        public void specialShow() {
            Console.WriteLine("This is specials");
        }

    }


    class SubSubClass : MyClass, ICalculate { 
        public int Calculate()
        {
            throw new NotImplementedException();
        }

        public void print()
        {
            throw new NotImplementedException();
        }
    }

    interface ICalculate
    {
        int Calculate();
    }

    interface IPrint{
        void print();
}

}
