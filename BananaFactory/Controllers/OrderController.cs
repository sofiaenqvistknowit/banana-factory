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
    public class OrderController : ControllerBase
    {
		     private readonly ILogger<OrderController> _logger;
		public OrderController(ILogger<OrderController> logger){
			_logger = logger;
		}
		public void Get() {
			
		}
    }
}