using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Sku { get; set; }
        public string Brand { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsEnabled { get; set; }
        public int MinQuantity { get; set; }
        public int MaxQuantity { get; set; }
        public EProductType ProductType { get; set; }
    }

    public enum EProductType
    {
        Licence = 0,
        Software = 1,
        Hardware = 2,
        Cloud = 3
    }
}
