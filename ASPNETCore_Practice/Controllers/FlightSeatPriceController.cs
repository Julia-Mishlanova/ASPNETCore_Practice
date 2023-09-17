using ASPNETCore_Practice.Domain;
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
    public class FlightSeatPriceController : Controller
    {
        private readonly IFlightSeatPriceService _flightSeatPriceService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public FlightSeatPriceController(
            IFlightSeatPriceService FlightSeatPriceService,
            IMapper mapper,
            ILogger logger
            )
        {
            _flightSeatPriceService = FlightSeatPriceService ?? throw new ArgumentNullException(nameof(FlightSeatPriceService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetFlightStatus(int id)
        {
            try
            {
                var flightSeatPrice = _flightSeatPriceService.GetFlightSeatPriceById(id);
                if (flightSeatPrice == null)
                {
                    _logger.LogInformation($"FlightSeatPrice with id {id}, not found.");
                    return NotFound();
                }

                var flightSeatPriceDTO = _mapper.Map<FlightSeatPriceDTO>(flightSeatPrice);
                return Ok(flightSeatPriceDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
