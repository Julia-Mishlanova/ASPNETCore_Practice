using ASPNETCore_Practice.Models.DTO;
using ASPNETCore_Practice.Services.IServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Services
{
    public class FakeCountryService : IСountryService
    {
        private List<CountryDTO> countries;
        private int nextId = 1;

        public FakeCountryService()
        {
            countries = new List<CountryDTO>
            {
                new CountryDTO { Id = nextId++, Name = "Country 1" },
                new CountryDTO { Id = nextId++, Name = "Country 2" },
                new CountryDTO { Id = nextId++, Name = "Country 3" }
            };
        }

        public IEnumerable<CountryDTO> GetAllCountries()
        {
            return countries;
        }

        public CountryDTO GetCountryById(int id)
        {
            return countries.FirstOrDefault(c => c.Id == id);
        }

        public void AddCountry(CountryDTO country)
        {
            country.Id = nextId++;
            countries.Add(country);
        }

        public void UpdateCountry(CountryDTO updatedCountry)
        {
            var existingCountry = countries.FirstOrDefault(c => c.Id == updatedCountry.Id);
            if (existingCountry != null)
            {
                existingCountry.Name = updatedCountry.Name;
            }
        }

        public void DeleteCountry(int id)
        {
            var countryToDelete = countries.FirstOrDefault(c => c.Id == id);
            if (countryToDelete != null)
            {
                countries.Remove(countryToDelete);
            }
        }
    }
}
