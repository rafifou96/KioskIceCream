using DAL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Collections.ObjectModel;

namespace BL
{
    public class BL : Interfaces.IFunctionalities
    {
        #region Constructor
        private DAL.DAL DALinstance;
        private BL()
        {
            DALinstance = DAL.DAL.GetInstance();
        }

        private static BL instance = null;

        public static BL GetInstance()
        {
            if (instance == null)
                instance = new BL();
            return instance;
        }
        #endregion

        public async Task AddIceCream(IceCream iceCream)
        {
            await DALinstance.AddIceCream(iceCream);
        }

        public async Task UpdateIceCream(IceCream iceCream)
        {
            await DALinstance.UpdateIceCream(iceCream);
        }

        public async Task DeleteIceCream(int iceCreamID)
        {
            await DALinstance.DeleteIceCream(iceCreamID);
        }

        public async Task AddShop(Shop shop)
        {
            await DALinstance.AddShop(shop);
        }

        public async Task UpdateShop(Shop shop)
        {
            await DALinstance.UpdateShop(shop);
        }

        public async Task DeleteShop(int shopID)
        {
            await DALinstance.DeleteShop(shopID);
        }

        public ObservableCollection<Shop> GetAllShops(Func<Shop, bool> filter = null)
        {
            return DALinstance.GetAllShops();
        }

        public ObservableCollection<Rating> GetAllRatings(IceCream iceCream)
        {
            return DALinstance.GetAllRatings(iceCream);
        }

        public ObservableCollection<IceCream> GetAllIceCreams(Func<IceCream, bool> filter = null)
        {
            return DALinstance.GetAllIceCreams();
        }

    }
}
