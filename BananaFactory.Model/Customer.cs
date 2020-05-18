using System;

namespace BananaFactory.Model
{
    public class Customer
    {
        // ReSharper disable once InconsistentNaming
        public int CustomerID { get; set; }

        public string Surname { get; set; }
        public string GivenName { get; set; }
        public string Address { get; set; }
        public string ZipCode { get; set; }
        public string City { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
    }
}
