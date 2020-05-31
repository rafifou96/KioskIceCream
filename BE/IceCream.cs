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
    public class IceCream
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key, Column(Order = 0)]
        public int ID { get; set; }

        public string Name { get; set; }
        public double? Energy { get; set; }
        public double? Sugar { get; set; }
        public double? Fat { get; set; }

        public string Description { get; set; }
        public string Flavour { get; set; }
        public double AverageRate { get; set; }
        public string ImageURL { get; set; }

        public Shop Shop { get; set; }
        public virtual List<Rating> Ratings { get; set; }

        public IceCream()
        {
            Ratings = new List<Rating>();
            Shop = new Shop();
        }
    }
}
