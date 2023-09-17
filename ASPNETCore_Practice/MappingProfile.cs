using ASPNETCore_Practice.Domain;
using ASPNETCore_Practice.Models;
using ASPNETCore_Practice.Models.DTO;
using AutoMapper;

namespace ASPNETCore_Practice
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<Product, ProductDTO>();
            CreateMap<Airport, AirportDTO>();
            CreateMap<Booking, BookingDTO>();
            CreateMap<Client, ClientDTO>();
            CreateMap<Country, CountryDTO>();
            CreateMap<Flight, FlightDTO>();
            CreateMap<FlightSeatPricePrice, FlightSeatPriceDTO>();
            CreateMap<FlightStatus, FlightStatusDTO>();
        }
    }
}
