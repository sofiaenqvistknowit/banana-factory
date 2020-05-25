using BananaFactory.Model;
using BananaFactory.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Repository.Repositories
{
   public class OrderRepository : Repository<Order>, IOrderRepository
    {
        public OrderRepository(BananaFactoryDbContext context) : base(context) { }
    }
}
