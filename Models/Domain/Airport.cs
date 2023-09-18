using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Airport : BaseEntity
    {
        public string Name { get; set; }
        public string City { get; set; }

        [AllowNull]
        public int CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }
    }
}
