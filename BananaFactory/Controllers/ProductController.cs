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
    public class ProductController : ControllerBase
    {
		     private readonly ILogger<ProductController> _logger;
		public ProductController(ILogger<ProductController> logger){
			_logger = logger;
		}
		
		public void Get() {
			
		}
    }
}