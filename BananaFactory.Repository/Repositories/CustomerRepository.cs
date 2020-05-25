using BananaFactory.Model;
using BananaFactory.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Repository.Repositories
{
   public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BananaFactoryDbContext context) : base(context) { }
       public Customer GetByName(string name)
        {
            return context.Set<Customer>().FirstOrDefault(customer => customer.GivenName == name);
        }
    }
}
