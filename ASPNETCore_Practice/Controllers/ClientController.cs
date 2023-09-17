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
    public class ClientController : ControllerBase
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;
        private readonly ILogger _logger;

        public ClientController(
            IClientService clientService,
            IMapper mapper,
            ILogger logger
            )
        {
            _clientService = clientService ?? throw new ArgumentNullException(nameof(clientService));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        [HttpGet("{id}")]
        public IActionResult GetClient(int id)
        {
            try
            {
                var client = _clientService.GetClientById(id);
                if (client == null)
                {
                    _logger.LogInformation($"Client with id {id}, not found.");
                    return NotFound();
                }

                var clientDTO = _mapper.Map<ClientDTO>(client);
                return Ok(clientDTO);
            }
            catch (Exception ex)
            {
                _logger.LogInformation($"Error:{ex.Message}");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
