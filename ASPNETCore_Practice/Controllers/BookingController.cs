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
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public BookingController(
            IBookingService bookingService,
            IMapper mapper,
            ILogger logger
            )
        {
            _bookingService = bookingService ?? throw new ArgumentNullException(nameof(bookingService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            try 
            {
                var booking = _bookingService.GetBookingById(id);
                if (booking == null)
                {
                    _logger.LogInformation($"Booking with id {id}, not found.");
                    return NotFound();
                }

                var bookingDTO = _mapper.Map<BookingDTO>(booking);
                return Ok(bookingDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
