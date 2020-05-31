using BE;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IFunctionalities
    {
        Task AddIceCream(IceCream iceCream);
        Task UpdateIceCream(IceCream iceCream);
        Task DeleteIceCream(int iceCreamID);
        ObservableCollection<IceCream> GetAllIceCreams(Func<IceCream, bool> filter = null);

        Task AddShop(Shop shop);
        Task UpdateShop(Shop shop);
        Task DeleteShop(int shopID);
        ObservableCollection<Shop> GetAllShops(Func<Shop, bool> filter = null);

        ObservableCollection<Rating> GetAllRatings(IceCream iceCream);
    }
}
