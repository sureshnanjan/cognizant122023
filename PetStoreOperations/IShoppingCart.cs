using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreOperations
{
    class IShoppingCart
{
        string ItemID;
        string ProductID;
        string Description;
        bool InStock;
        int Quantity;
        decimal ListPrice;
        decimal TotalCost;

        bool checkCost() { return true; }
    }
}
