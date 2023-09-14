using Models;
using Models.ModelsDTO;
using AutoMapper;

namespace ASPNETCore_Practice
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Product, ProductDTO>();
        }
    }
}
