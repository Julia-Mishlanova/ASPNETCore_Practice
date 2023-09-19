using ASPNETCore_Practice.Models;
using ASPNETCore_Practice.Models.Domain;
using ASPNETCore_Practice.Models.DTO;
using AutoMapper;

namespace ASPNETCore_Practice
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Airport, AirportDTO>();
            CreateMap<Booking, BookingDTO>();
            CreateMap<Client, ClientDTO>()
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => $"{src.FirstName} {src.LastName}"));
            CreateMap<Country, CountryDTO>();
            CreateMap<Flight, FlightDTO>();
            CreateMap<FlightSeatPrice, FlightSeatPriceDTO>();
            CreateMap<FlightStatus, FlightStatusDTO>();
            CreateMap<Schedule, ScheduleDTO>();
            CreateMap<Direction, DirectionDTO>();
        }
    }
}
