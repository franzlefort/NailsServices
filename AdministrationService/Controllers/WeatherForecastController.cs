using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AdministrationService.Database.Contexts;
using AdministrationService.Database.Entities;
using AdministrationService.Database.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace AdministrationService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IDbRepository _dbRepository;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IDbRepository dbRepository)
        {
            _logger = logger;
            _dbRepository = dbRepository;
        }

        [HttpGet]
        public async Task<int> Get()
        {
            
            return await _dbRepository.SaveChangesAsync();
        }
    }
}
