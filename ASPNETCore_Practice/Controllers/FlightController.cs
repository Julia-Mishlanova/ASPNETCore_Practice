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
    public class FlightController : Controller
    {
        private readonly IFlightService _flightService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FlightController(
            IFlightService flightService,
            IMapper mapper,
            ILogger logger
            )
        {
            _flightService = flightService ?? throw new ArgumentNullException(nameof(flightService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetFlight(int id)
        {
            try
            {
                var Flight = _flightService.GetFlightById(id);
                if (Flight == null)
                {
                    _logger.LogInformation($"Flight with id {id}, not found.");
                    return NotFound();
                }

                var flightDTO = _mapper.Map<FlightDTO>(Flight);
                return Ok(flightDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
