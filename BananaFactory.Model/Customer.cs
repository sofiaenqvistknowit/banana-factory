using System;
using System.Collections;
using System.Collections.Generic;

namespace BananaFactory.Model
{
    public class Customer: BaseModel
    {
        public int CustomerID { get; set; }

        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }

        private ICollection<Order> Orders { get; set; }
    }
}
