using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Direction : BaseEntity
    {
        [AllowNull]
        public int OriginIataCode { get; set; }

        [ForeignKey("OriginIataCode")]
        public Airport AirportOrig { get; set; }

        public int DestinationIataCode { get; set; }

        [ForeignKey("DestinationIataCode")]
        public Airport AirportDest { get; set; }
    }
}
