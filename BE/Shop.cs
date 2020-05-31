using Microsoft.Maps.MapControl.WPF;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Shop
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int ID { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }

        public string Address { get; set; }
        public Location Location { get; set; }

        public string ImageURL { get; set; }

        public string Pseudo { get; set; }
        public string Password { get; set; }

        public virtual List<IceCream> Supply { get; set; }

        public Shop()
        {
            Supply = new List<IceCream>();
            Location = new Location();
        }
    }
}
