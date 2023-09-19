using ASPNETCore_Practice.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.DTO
{
    public class DirectionDTO : BaseDTO
    {
        public int OriginIataCode { get; set; }

        public Flight FlightOrig { get; set; }

        public string DestinationIataCode { get; set; }

    }
}
