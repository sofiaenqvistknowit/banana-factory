using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BananaFactory.Model.DTO;
using BananaFactory.Model;


namespace BananaFactory.Business.Mapping
{
    public static class CustomerMapper
    {
        public static CustomerDto ModelToDto(Customer model)
        {
            return new CustomerDto
            { 
                CustomerId = model.CustomerID,
                Address = model.Address,
                City = model.City,
                Email = model.Email,
                GivenName = model.GivenName,
                Surname = model.Surname,
                ZipCode = model.ZipCode
            };
        }
    }
}
