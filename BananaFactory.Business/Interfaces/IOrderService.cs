using BananaFactory.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Business.Interfaces
{
    public interface IOrderService
    {
        public List<OrderDto> GetAll();
        public OrderDto GetById(int Id);
    }
}