using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurant_app_backend.Model;

namespace restaurant_app_backend.Controllers
{
    [ApiController]
    [Route("restaurant")]
    public class RestaurantController : ControllerBase
    {
        private static readonly Restaurant[] MockRestaurants = new[]
        {
            new Restaurant("Restaurant 1", new List<Table>()
            {
                new Table(1, 2), new Table(1, 2), new Table(2, 4)
            }), 
            new Restaurant("Restaurant 2", new List<Table>()
            {
                new Table(1, 1), new Table(6,8)
            })
        };

        private readonly ILogger<RestaurantController> _logger;

        public RestaurantController(ILogger<RestaurantController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Restaurant[] GetAllRestaurants()
        {
            return MockRestaurants;
        }
    }
}
