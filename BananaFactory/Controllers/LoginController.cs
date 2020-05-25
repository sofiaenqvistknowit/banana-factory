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
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        public LoginController(ILogger<LoginController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Välkommen";
        }


        public string Login([FromBody] UserDto user)
        {
            if (user.UserName == "Soffan")
            {
                return "Yass, du är inloggad";
            }
            else
            {
                return "Najje, de gick ju inge bra";
            }

        }


    }

    public class UserDto
    {
        public string UserName { get; set; }
        //public string Password { get; set; }
    }
}