using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Model
{
    public class ProductType
    {
        public int ProductTypeID { get; set; }
        public string ProductTypeName { get; set; }
        public int? ParentProductTypeID { get; set; }
        public ProductType ParentProductType { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<ProductType> ChildProductTypes { get; set; }
    }
}
