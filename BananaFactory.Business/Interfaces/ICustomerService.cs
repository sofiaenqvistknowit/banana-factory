using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Business.Interfaces
{
    public interface ICustomerService
    {
        public List<Model.DTO.CustomerDto> GetAll();
        public Model.DTO.CustomerDto GetByName(string v);
    }
}