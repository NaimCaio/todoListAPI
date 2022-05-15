using ImpactaAPI.Models;
using ImpactaAPI.Models.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ImpactaAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [EnableCors("AuthPolicy")]
    public class AuthenticatorController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAuthService _authService;
        private readonly User _adminUser; 

        public AuthenticatorController(IAuthService authService)
        {
            _authService = authService;
            _adminUser.email = Environment.GetEnvironmentVariable("adminEmail");
            _adminUser.senha = Environment.GetEnvironmentVariable("adminPass");
        }
        [HttpPost]
        [Route("AuthenticateUser")]
        public User Authenticate([FromBody]  User user)
        {
            var userAuth = _authService.AutheticateUser(user);
            return userAuth;
        }

        [HttpPost]
        [Route("AddUser")]
        public User AddNewUser([FromBody] User user)
        {
            var userAuth = _authService.AddUser(user);
            return userAuth;
        }
    }
}
