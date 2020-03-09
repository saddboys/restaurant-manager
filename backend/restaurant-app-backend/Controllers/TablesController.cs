using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using restaurant_app_backend.Model;

namespace restaurant_app_backend.Controllers
{
    [ApiController]
    [Route("user")]
    public class TableController : ControllerBase
    {
        private static readonly Table MockTable = new Table(0, 1, 
            new List<Availability>() {new Availability(new DateTime(2020, 11, 5, 11, 9, 0), 
            Time.MAP.GetValueOrDefault("9am"), 
            Time.MAP.GetValueOrDefault("10am"))});
        
        private readonly ILogger<TableController> _logger;
        
        
        public TableController(ILogger<TableController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public Table GetTable(int id)
        {
            return MockTable;
        }
        
        
        
        
    }
}