using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.DTO
{
    public class ClientDTO : BaseDTO
    {
        public string FullName { get; set; }
        public string Phone { get; set; }
        public int CountryId { get; set; }
    }
}
