using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BananaFactory.Business.Mapping;
using BananaFactory.Model;
using BananaFactory.Model.DTO;
using BananaFactory.Repository;
using BananaFactory.Repository.Repositories;
using Microsoft.EntityFrameworkCore.Migrations.Operations;

namespace BananaFactory.Business
{
    public class CustomerService : Interfaces.ICustomerService
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

            var customers = new List<Customer>();
            customers.Add(new Customer
            {
                CustomerID = 1,
                Address = "Lidnesberg",
                City = "Llindesberg",
                Email = "sogia@mail.com",
                GivenName = "Enqvist",
                PasswordHash = "lösen",
                Surname = "Sofia",
                ZipCode = "71193"
            });
            customers.Add(new Customer
            {
                CustomerID = 2,
                Address = "Björka 572",
                City = "Llindesberg",
                Email = "sofia@mail.com",
                GivenName = "Enqvist",
                PasswordHash = "lösen",
                Surname = "Sofia",
                ZipCode = "71193"
            });

            var customersDTO = new List<CustomerDto>();
            foreach (var customer in customers)
            {
               customersDTO.Add(CustomerMapper.ModelToDto(customer));
            }
            return customersDTO;
            //var customers = _customerRepository.GetAll().ToList();
        }

        public CustomerDto GetById(int id)
        {
            return CustomerMapper.ModelToDto(_customerRepository.GetById(id));
        }
        public CustomerDto GetByName(string v)
        {
            var customer = _customerRepository.GetByName(v);
            return CustomerMapper.ModelToDto(customer);
//            return _mapper.Map<CustomerDto>(customer);
        }
    }
}
