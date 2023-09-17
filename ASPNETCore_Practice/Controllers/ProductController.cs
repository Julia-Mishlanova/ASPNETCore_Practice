//using Models;
//using AutoMapper;
//using LoggerService;
//using Microsoft.AspNetCore.Mvc;
//using Services.IServices;
//using ASPNETCore_Practice.Models.DTO;

//namespace ASPNETCore_Practice.Controllers
//{
//    [ApiController]
//    [Route("[controller]")]
//    public class ProductController : Controller
//    {
//        private readonly IProductService _productService;
//        private readonly ILoggerManager _logger;
//        private readonly IMapper _mapper;

//        public ProductController(IMapper mapper, ILoggerManager logger)
//        {
//            _mapper = mapper;
//            _logger = logger;
//        }

//        [HttpGet]
//        public ActionResult<ProductDTO> Get(int id)
//        {
//            _logger.LogInfo("Get Product");

//            var product = _productService.GetProductById(id);
//            if (product == null)
//            {
//                return NotFound();
//            }
            
//            var productDTO = _mapper.Map<ProductDTO>(product);
//            return productDTO;
//        }
//    }
//}
