using BE;
using DAL;
using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    public class TestsDAL
    {
        static BL.BL bl = BL.BL.GetInstance();
        static void Main(string[] args)
        {
            //TestDel();
            //TestAllIC();
            //TestUpdate();
            //AddIceCreams();

            Console.WriteLine("Begin");

            //AddShops();
            //TestConnexion();
            //TestGetAlls();

            DatabaseInitialisationAsync();
            Console.WriteLine("End");

            Console.Read();
        }

        static void DatabaseInitialisationAsync()
        {
            var ic = new List<IceCream>
            {
                new IceCream { Name = "Magnum", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 20, Sugar = 20, AverageRate = 5, ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\9.jpg", Ratings = new List<Rating> { new Rating { Author = "Gab", Rate = 5, Description = "Top" } } },
                new IceCream { Name = "Mag", Flavour = "Vanille", Description = "Awesome ice cream", Energy = 230, Fat = 40, Sugar = 80, AverageRate = 4, ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\10.jpg", Ratings = new List<Rating> { new Rating { Author = "Anaelle", Rate = 4, Description = "Kiffe" } } },
                new IceCream { Name = "Num", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 60, Sugar = 100, AverageRate = 3, ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\11.jpg", Ratings = new List<Rating> { new Rating { Author = "Jo", Rate = 3, Description = "Bien" } } }
            };


            var shops = new List<Shop> {new Shop { Name = "Tip Top Shop 1", Address = "Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0123589674", Website = "miam.fr", ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\m1.jpg", Supply = ic },
                new Shop { Name = "Tip Top Shop 2", Address = "2 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.com", ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\m2.jpg", Supply = ic },
                new Shop { Name = "Tip Top Shop 3", Address = "3 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\A.jpg", Supply = ic  },
                new Shop { Name = "Tip Top Shop 4", Address = "4 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = @"C:\Users\Raphael Amar\source\repos\IceCreamKiosk\Assets\Z.jpg", Supply = ic  } };


            foreach (var item in ic)
            {
                bl.AddIceCream(item);
            }

            foreach (var item in shops)
            {
                bl.AddShop(item);
            }


            Console.WriteLine("Fini !");
        }

        static void AddShops()
        {
            var ic = new List<IceCream>
            {
                new IceCream { Name = "Magnum", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 20, Sugar = 20, AverageRate = 5, ImageURL = "C:/Users/gabri/Pictures/9.jpg", Ratings = new List<Rating> { new Rating { Author = "Gab", Rate = 5, Description = "Top" } } },
                new IceCream { Name = "Mag", Flavour = "Vanille", Description = "Awesome ice cream", Energy = 230, Fat = 40, Sugar = 80, AverageRate = 4, ImageURL = "C:/Users/gabri/Pictures/10.jpg", Ratings = new List<Rating> { new Rating { Author = "Anaelle", Rate = 4, Description = "Kiffe" } } },
                new IceCream { Name = "Num", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 60, Sugar = 100, AverageRate = 3, ImageURL = "C:/Users/gabri/Pictures/11.jpg", Ratings = new List<Rating> { new Rating { Author = "Jo", Rate = 3, Description = "Bien" } } }
            };


            var shops = new List<Shop> {new Shop { Name = "Tip Top Shop 1", Address = "Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0123589674", Website = "miam.fr", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic },
                new Shop { Name = "Tip Top Shop 2", Address = "2 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.com", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic },
                new Shop { Name = "Tip Top Shop 3", Address = "3 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic  },
                new Shop { Name = "Tip Top Shop 4", Address = "4 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic  } };


            foreach (var item in ic)
            {
                bl.AddIceCream(item);
            }

            foreach (var item in shops)
            {
                bl.AddShop(item);
            }

            Console.WriteLine("Fini !");
        }

        static void TestConnexion()
        {
            var a = bl.GetAllShops();
            if (a.Count(x => x.Pseudo == "Gab1" && x.Password == "Gab") == 1)
            {
                Console.WriteLine("OK");
            }

        }

        static void TestGetAlls()
        {
            var list = bl.GetAllIceCreams();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Ratings.Count}");
            }
        }

        static async void AddIceCreams()
        {
            //var a = new IceCream { Name = "Magnum", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 20, Sugar = 20, AverageRate = 5, ImageURL = "C:/Users/gabri/Pictures/11.jpg", Ratings = new List<Rating> { new Rating { Author = "Gab", Rate = 5, Description = "Top" } } };

            var a = bl.GetAllIceCreams();

            var f = a[0];

            f.Name = "Chcco";
            f.Ratings.Add(new Rating { Author = "Gabriel 28/5"});

            await bl.UpdateIceCream(f);

            a = bl.GetAllIceCreams();

            foreach (var item in a)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Ratings.Count}");
            }

            //bl.AddIceCream(a);
        }


        //static void AddShops()
        //{
        //    var ic = new List<IceCream>
        //    {
        //        new IceCream { Name = "Magnum", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 20, Sugar = 20, AverageRate = 5, ImageURL = "C:/Users/gabri/Pictures/9.jpg", Ratings = new List<Rating> { new Rating { Author = "Gab", Rate = 5, Description = "Top" } } },
        //        new IceCream { Name = "Mag", Flavour = "Vanille", Description = "Awesome ice cream", Energy = 230, Fat = 40, Sugar = 80, AverageRate = 4, ImageURL = "C:/Users/gabri/Pictures/10.jpg", Ratings = new List<Rating> { new Rating { Author = "Anaelle", Rate = 4, Description = "Kiffe" } } },
        //        new IceCream { Name = "Num", Flavour = "Chocolat", Description = "Awesome ice cream", Energy = 230, Fat = 60, Sugar = 100, AverageRate = 3, ImageURL = "C:/Users/gabri/Pictures/11.jpg", Ratings = new List<Rating> { new Rating { Author = "Jo", Rate = 3, Description = "Bien" } } }
        //    };
        

        //var shops = new List<Shop> {new Shop { Name = "Tip Top Shop 1", Address = "Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0123589674", Website = "miam.fr", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic },
        //        new Shop { Name = "Tip Top Shop 2", Address = "2 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.com", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic },
        //        new Shop { Name = "Tip Top Shop 3", Address = "3 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic  },
        //        new Shop { Name = "Tip Top Shop 4", Address = "4 Rue de la Marne", Location = new Location(48.966437, 2.301460), Phone = "0145859620", Website = "miam.co.it", ImageURL = "C:/Users/gabri/Pictures/m2.jpg", Supply = ic  } };


        //    foreach (var item in ic)
        //    {
        //        bl.AddIceCream(item);
        //    }

        //    foreach (var item in shops)
        //    {
        //        bl.AddShop(item);
        //    }

        //    Console.WriteLine("Fini !");
        //}

        static async void TestDel()
        {
            await DAL.DAL.GetInstance().DeleteIceCream(3);
        }

        static async void TestUpdate()
        {
            using (var db = new DALContext())
            {
                var oldI = await db.IceCreams.FindAsync(4);
                var newI = oldI;

                newI.Name = "IKEA 222";
                db.Entry(oldI).CurrentValues.SetValues(newI);
                await db.SaveChangesAsync();
            }
        }

        static async void TestAllIC()
        {
            var list = bl.GetAllIceCreams();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Ratings.Count}");
            }

            var f = list[1];
            f.Ratings.Add(new Rating { Author = "Gab", Description = "Top", Rate = 5 });

            await bl.UpdateIceCream(f);

            list = bl.GetAllIceCreams();

            foreach (var item in list)
            {
                Console.WriteLine($"{item.ID} {item.Name} {item.Ratings.Count}");
            }
        }


        static async void AddIceCream()
        {
            using (var db = new DALContext())
            {
                IceCream a = new IceCream { Name = "IKEA" };

                Rating rating = new Rating { Author = "Gab", Description = "Super glace", Rate = 4 };
                Rating rating2 = new Rating { Author = "Jo", Description = "Mouais", Rate = 5 };

                a.Ratings.Add(rating);
                a.Ratings.Add(rating2);

                Shop shop = new Shop { Address = "Rue des Ardennes", Name = "IceCream Shop" };
                shop.Supply.Add(a);

                db.IceCreams.Add(a);
                db.Shops.Add(shop);

                await db.SaveChangesAsync();

                Console.WriteLine("Fin");

                Retrieve();

                Console.Read();
            }
        }

        static void Retrieve()
        {
            using (var db = new DALContext())
            {
                foreach (var ice in db.IceCreams)
                {
                    foreach (var rate in ice.Ratings)
                    {
                        Console.WriteLine($"{rate.Author}: {rate.Description} ** {rate.Rate}");
                    }
                }
            }
        }

        static async void Update()
        {
            using (var db = new DALContext())
            {
                var ice = db.IceCreams.First();

                Console.WriteLine("Avant ");
                Console.WriteLine($"{ice.Name} {ice.Description}");

                var newIce = ice;

                newIce.Description = "Une nouvelle description";
                newIce.AverageRate = 4;

                db.Entry(ice).CurrentValues.SetValues(newIce);
                await db.SaveChangesAsync();

                var icen = db.IceCreams.First();
                Console.WriteLine($"{icen.Name} {icen.Description}");
            }
        }

        static void Delete()
        {
            int id = 1;
            using (var db = new DALContext())
            {
                db.IceCreams.Add(new IceCream { Name = "A supprimer" });
                db.SaveChanges();

                foreach (var iceC in db.IceCreams)
                {
                    Console.WriteLine($"Avant\nName: {iceC.Name}");
                }

                Console.WriteLine("*****");

                var icetod = db.IceCreams.Where(x => x.ID == id).FirstOrDefault();
                Console.WriteLine($"{icetod.ID} {icetod.Name}");
                db.IceCreams.Remove(icetod);
                db.SaveChanges();

                foreach (var iceC in db.IceCreams)
                {
                    Console.WriteLine($"Après\nName: {iceC.Name}");
                }
            }
        }

        static void AllIC(Func<IceCream, bool> predicate)
        {
            using (var db = new DALContext())
            {
                var chocos = db.IceCreams.Where(predicate).ToList();
                var fraises = db.IceCreams.Where(x => x.Description.Contains("fraise")).ToList();

                Console.WriteLine(chocos.Count);
                Console.WriteLine(fraises.Count);
                Console.Read();
            }
        }

    }
}
