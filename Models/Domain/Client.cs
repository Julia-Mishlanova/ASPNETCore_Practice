using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Client : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Passport { get; set; }

        [AllowNull]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
