using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Model
{
    public class Supplier
    {
        public int SupplierID { get; set; }
        public string Name { get; set; }
        public string OrganizationNumber { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
