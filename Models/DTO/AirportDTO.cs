using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.DTO
{
    public class AirportDTO : BaseDTO
    {
        public string Name { get; set; }
        public string City { get; set; }
        public int CountryId { get; set; }
    }
}
