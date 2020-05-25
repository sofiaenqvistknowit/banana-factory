using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BananaFactory.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
		     private readonly ILogger<CustomerController> _logger;
		public CustomerController(ILogger<CustomerController> logger){
            _logger = logger;
		}

        [HttpGet]
        public CustomerDto Get()
        {
			return new CustomerDto
            {
                Surname = "Sofia",
                Lastname = "Enqvist",
                ZipCode = "71193",
                City = "Lindesberg"
            };
		}
    }
}