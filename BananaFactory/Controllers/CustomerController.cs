using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BananaFactory.Business;
using BananaFactory.Model.DTO;


namespace BananaFactory.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ILogger<CustomerController> _logger;
        private readonly CustomerService _customerService;
        public CustomerController(ILogger<CustomerController> logger, CustomerService customerService)
        {
            _logger = logger;
            _customerService = customerService;
        }

        [HttpGet]
        public List<CustomerDto> GetAll()
        {
            return _customerService.GetAll();
        }
    }
}