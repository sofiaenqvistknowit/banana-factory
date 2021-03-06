﻿using BananaFactory.Model.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Business.Interfaces
{
    public interface ICustomerService
    {
        public List<CustomerDto> GetAll();
        public CustomerDto GetByName(string v);
        public CustomerDto GetById(int Id);
    }
}