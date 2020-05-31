using BE;
using Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DAL : Interfaces.IFunctionalities
    {
        #region Constructor
        private DAL() { }
        private static DAL instance = null;

        public static DAL GetInstance()
        {
            if (instance == null)
                instance = new DAL();
            return instance;
        }
        #endregion

        public async Task AddIceCream(IceCream iceCream)
        {
            using (var db = new DALContext())
            {
                db.IceCreams.Add(iceCream);
                await db.SaveChangesAsync();
            }
        }

        public async Task UpdateIceCream(IceCream newIceCream)
        {
            using (var db = new DALContext())
            {
                IceCream oldIceCream = await db.IceCreams.SingleOrDefaultAsync(x => x.ID == newIceCream.ID);

                if (oldIceCream != null)
                {
                    foreach (var item in newIceCream.Ratings)
                    {
                        if (oldIceCream.Ratings.Find(x => x.ID == item.ID) == null)
                            oldIceCream.Ratings.Add(item);
                    }
                }

                db.IceCreams.AddOrUpdate(newIceCream);
                await db.SaveChangesAsync();
            }
        }

        public async Task DeleteIceCream(int iceCreamID)
        {
            using (var db = new DALContext())
            {
                IceCream a = await db.IceCreams.FindAsync(iceCreamID);
                db.Entry(a).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }
        }

        public async Task AddShop(Shop shop)
        {
            using (var db = new DALContext())
            {
                db.Shops.Add(shop);
                await db.SaveChangesAsync();
            }
        }

        public async Task UpdateShop(Shop newShop)
        {
            using (var db = new DALContext())
            {
                Shop oldShop = await db.Shops.SingleOrDefaultAsync(x => x.ID == newShop.ID);

                if (oldShop != null)
                {
                    if (oldShop.Supply.Count() > newShop.Supply.Count())
                    {
                        var deletedItems = oldShop.Supply.Where(i => newShop.Supply.Find(n => n.ID == i.ID) == null).ToList();

                        foreach (var item in deletedItems)
                        {
                            oldShop.Supply.Remove(item);
                        }

                        db.Shops.Remove(oldShop);
                        await db.SaveChangesAsync();
                    }
                    else
                    {
                        foreach (var item in newShop.Supply)
                        {
                            if (oldShop.Supply.Find(x => x.ID == item.ID) == null)
                                oldShop.Supply.Add(item);
                        }
                    }
                }

                //db.Entry(oldShop).CurrentValues.SetValues(newShop);

                db.Shops.AddOrUpdate(newShop);
                await db.SaveChangesAsync();
            }
        }

        public async Task DeleteShop(int shopID)
        {
            using (var db = new DALContext())
            {
                Shop shop = await db.Shops.FindAsync(shopID);
                db.Entry(shop).State = EntityState.Deleted;
                await db.SaveChangesAsync();
            }
        }

        public ObservableCollection<IceCream> GetAllIceCreams(Func<IceCream, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list = new ObservableCollection<IceCream>(db.IceCreams
                    .Distinct()
                    .Include(i => i.Ratings)
                    .Include(i => i.Shop)
                    .AsNoTracking());

                return new ObservableCollection<IceCream>(list.Where(i => i.Name != null));
            }
        }

        public ObservableCollection<Shop> GetAllShops(Func<Shop, bool> filter = null)
        {
            using (var db = new DALContext())
            {
                var list =  new ObservableCollection<Shop>(db.Shops
                    .Distinct()
                    .Include(i => i.Supply)
                    .AsNoTracking())
                    .ToList();

                return new ObservableCollection<Shop>(list.Where(i => i.Name != null));
            }
        }

        public ObservableCollection<Rating> GetAllRatings(IceCream iceCream)
        {
            return null;
        }
    }
}
