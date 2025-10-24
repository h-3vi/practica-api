using Microsoft.AspNetCore.Mvc;
using MyAspNetCoreApp.Data;
using MyAspNetCoreApp.Models;

namespace MyAspNetCoreApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Привет" });
        }
    }
}