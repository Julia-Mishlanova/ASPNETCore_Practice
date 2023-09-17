using ASPNETCore_Practice.Models.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services.IServices
{
    public interface IСountryService
    {
        IEnumerable<CountryDTO> GetAllCountries();
        CountryDTO GetCountryById(int id);
        void AddCountry(CountryDTO country);
        void UpdateCountry(CountryDTO country);
        void DeleteCountry(int id);
    }
}
