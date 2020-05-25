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
    public class OrderController : ControllerBase
    {
		     private readonly ILogger<OrderController> _logger;
		private readonly OrderService _orderService;

		public OrderController(ILogger<OrderController> logger, OrderService orderService){
			_logger = logger;
			_orderService = orderService;
		}

		[HttpGet]
		[Route("GetAll")]
		public List<OrderDto> GetAll() {
			return _orderService.GetAll();
		}

		[HttpGet]
		[Route("GetById")]
		public OrderDto GetById(int id)
		{
            return _orderService.GetById(id);
		}
	}
}