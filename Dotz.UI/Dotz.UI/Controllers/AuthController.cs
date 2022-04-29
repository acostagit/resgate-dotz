using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dotz.UI.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Microsoft.Identity.Client;

namespace Dotz.UI.Controllers
{
    //private readonly UserManager<IdentityUser> _userManager;
    //private readonly AppSettings _appSettings;
    //private readonly ILogger _logger;

    //public AuthController(UserManager<IdentityUser> userManager,
    //                          IOptions<AppSettings> appSettings,
    //                          ILogger<AuthController> logger) 
    //{
    //    //_userManager = userManager;
    //    //_logger = logger;
    //    //_appSettings = appSettings.Value;
    //}

    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        //TO DO
        // [HttpPost("novaconta")]
        //public async Task<ActionResult> Registrar(RegisterUserModel registerUser)
        //{
        //}        //public async Task<ActionResult> Registrar(RegisterUserModel registerUser)
        //{

        //TO DO
        //[HttpPost("logar")]
        //public async Task<ActionResult> Login(LoginUserViewModel loginUser)
        //{
        }
}
