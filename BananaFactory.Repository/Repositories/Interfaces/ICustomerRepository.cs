﻿using BananaFactory.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BananaFactory.Repository.Interfaces
{
    public interface ICustomerRepository
    {
        public Customer GetByName(string name);
    }
}
