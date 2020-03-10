using System;
using System.Collections.Generic;
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
                new Table(1, 2, new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                    Time.MAP.GetValueOrDefault("9am"), 
                    Time.MAP.GetValueOrDefault("10am"))}), 
                new Table(1, 2, new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                    Time.MAP.GetValueOrDefault("9am"), 
                    Time.MAP.GetValueOrDefault("10am"))}), 
                new Table(2, 4, new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                    Time.MAP.GetValueOrDefault("9am"), 
                    Time.MAP.GetValueOrDefault("10am"))})
            }), 
            new Restaurant("Restaurant 2", new List<Table>()
            {
                new Table(1, 1, new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                    Time.MAP.GetValueOrDefault("9am"), 
                    Time.MAP.GetValueOrDefault("10am"))}), 
                new Table(6, 8, new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                    Time.MAP.GetValueOrDefault("9am"), 
                    Time.MAP.GetValueOrDefault("10am"))})
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
