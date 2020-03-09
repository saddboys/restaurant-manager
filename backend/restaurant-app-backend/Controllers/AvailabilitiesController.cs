using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace restaurant_app_backend.Controllers
{
    [ApiController]
    [Route("availabilities")]
    public class AvailabilitiesController : ControllerBase
    {
        private static readonly Availability[] AVAILABILITIES = new[]
        {
            new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
                Time.MAP.GetValueOrDefault("9am"), 
                Time.MAP.GetValueOrDefault("10am"))
        };

        private readonly ILogger<AvailabilitiesController> _logger;

        public AvailabilitiesController(ILogger<AvailabilitiesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Availability[] GetAvailabilities(string restaurant, DateTime date)
        {
            if (restaurant == null || date == null)
            {
                return null;
            }
            return AVAILABILITIES;
        }
        
        
    }
}