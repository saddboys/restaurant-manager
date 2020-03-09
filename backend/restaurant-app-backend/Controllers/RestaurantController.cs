using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace restaurant_app_backend.Controllers
{
    [ApiController]
    [Route("test")]
    public class RestaurantController : ControllerBase
    {
        private static readonly string[] Names = new[]
        {
            "Restaurant 1", "Restaurant 2"
        };

        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public String[] Get()
        {
            return Names;
        }
    }
}
