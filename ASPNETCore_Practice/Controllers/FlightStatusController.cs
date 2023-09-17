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
    public class FlightStatusController : Controller
    {
        private readonly IFlightStatusService _flightStatusService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FlightStatusController(
            IFlightStatusService FlightStatusService,
            IMapper mapper,
            ILogger logger
            )
        {
            _flightStatusService = FlightStatusService ?? throw new ArgumentNullException(nameof(FlightStatusService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetFlightStatus(int id)
        {
            try
            {
                var FlightStatus = _flightStatusService.GetFlightStatusById(id);
                if (FlightStatus == null)
                {
                    _logger.LogInformation($"FlightStatus with id {id}, not found.");
                    return NotFound();
                }

                var FlightStatusDTO = _mapper.Map<FlightStatusDTO>(FlightStatus);
                return Ok(FlightStatusDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
