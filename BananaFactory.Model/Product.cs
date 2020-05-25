using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Model
{
    public class Product
    {
        public int ProductID { get; set; }
        public int SupplierID { get; set; }
        public Supplier Supplier { get; set; }
        public int ProductTypeID { get; set; }
        public ProductType ProductType { get; set; }
        public string Name { get; set; }
        public ProductColor Color { get; set; }
        public string Size { get; set; }
        public float Weight { get; set; }
        public decimal Price { get; set; }
        public ICollection<ProductImage> Images { get; set; }
        public ICollection<OrderProduct> Orders { get; set; }
    }
}
