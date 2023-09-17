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
    public class CountryController : Controller
    {
        private readonly IСountryService _countryService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public CountryController(
            IСountryService countryService,
            IMapper mapper,
            ILogger logger
            )
        {
            _countryService = countryService ?? throw new ArgumentNullException(nameof(countryService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetCountry(int id)
        {
            try
            {
                var Country = _countryService.GetCountryById(id);
                if (Country == null)
                {
                    _logger.LogInformation($"Country with id {id}, not found.");
                    return NotFound();
                }

                var CountryDTO = _mapper.Map<CountryDTO>(Country);
                return Ok(CountryDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
