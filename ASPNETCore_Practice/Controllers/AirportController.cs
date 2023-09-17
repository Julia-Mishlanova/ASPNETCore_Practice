using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;

namespace ASPNETCore_Practice.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AirportController : ControllerBase
    {
        private readonly IAirportService _airportService;
        private readonly IMapper _mapper;
        private readonly ILogger<AirportController> _logger;

        public AirportController(
            IAirportService airportService,
            IMapper mapper,
            ILogger<AirportController> logger)
        {
            _airportService = airportService ?? throw new ArgumentNullException(nameof(airportService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetAirport(int id)
        {
            try
            {
                var airport = _airportService.GetAirportById(id);
                if (airport == null)
                {
                    _logger.LogInformation($"Airport with id {id} not found.");
                    return NotFound();
                }

                var airportDto = _mapper.Map<AirportDTO>(airport);
                return Ok(airportDto);
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error: {ex}");
                return StatusCode(500, "Internal server error");
            }
        }

    }
}
