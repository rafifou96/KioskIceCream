using BE;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DALContext : DbContext
    {
        public DbSet<IceCream> IceCreams { get; set; }
        public DbSet<Shop> Shops { get; set; }

        public DALContext()
        {
            //this.Configuration.LazyLoadingEnabled = false;
            //this.Configuration.ProxyCreationEnabled = false;
        }
    }
}
