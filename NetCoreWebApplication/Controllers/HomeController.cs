using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;

namespace NetCoreWebApplication.Controllers
{
    [Route("api/[controller]")]
    public class HomeController : Controller
    {
        private ILogger Logger { get; }

        public HomeController(ILogger<HomeController> logger)
        {
            Logger = logger;
            Logger.LogDebug("Home controller is constructed");
        }

        [HttpGet]
        public IEnumerable<string> Index()
        {
            Logger.LogDebug("Hi");
            return new string[] { "Hello", "World" };
        }
    }
}