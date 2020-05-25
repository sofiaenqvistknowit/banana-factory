using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BananaFactory.Model;
using BananaFactory.Model.DTO;
using BananaFactory.Repository;
using BananaFactory.Repository.Repositories;

namespace BananaFactory.Business
{
    public class CustomerService: Interfaces.ICustomerService
    {
        private readonly CustomerRepository _customerRepository;
        private readonly IMapper _mapper;

        public CustomerService(CustomerRepository customerRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _mapper = mapper;
        }

        public List<CustomerDto> GetAll()
        {
            var customers = _customerRepository.GetAll().ToList();
            List<CustomerDto> customersDTO = new List<CustomerDto>();
            return _mapper.Map<List<CustomerDto>>(customers);
        }

        public CustomerDto GetByName(string v)
        {
           var customer = _customerRepository.GetByName(v);
           return _mapper.Map<CustomerDto>(customer);
        }
    }
}
