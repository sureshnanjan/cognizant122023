using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetStoreOperations
{
    public interface IHomePageOperations
    {
        IShoppingCart _mycart;
        AdminOptions options;
        string getLogoInformation();
        string[] getAvailablePets();
        void accessPetCategory(string categoryName);

        string[] doSearch(string keyword);

        void accessCart();

        string[] getAdminOptions(string param);


    }
}
