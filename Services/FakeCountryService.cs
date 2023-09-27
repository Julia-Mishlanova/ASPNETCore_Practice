using ASPNETCore_Practice.DataAccess.Repository.IRepository;
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
        private ICountryRepository _countryRepository;
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
            return _countryRepository.GetAll();
        }

        public CountryDTO GetCountryById(int id)
        {
            return _countryRepository.Find(id);
        }

        public void AddCountry(CountryDTO country)
        {
            _countryRepository.Add(country);
        }

        public void UpdateCountry(CountryDTO updatedCountry)
        {
            _countryRepository.Update(updatedCountry);
        }

        public void DeleteCountry(int id)
        {
            var countryToDelete = _countryRepository.Find(id);
            if (countryToDelete != null)
            {
                _countryRepository.Remove(countryToDelete);
            }
        }
    }
}
