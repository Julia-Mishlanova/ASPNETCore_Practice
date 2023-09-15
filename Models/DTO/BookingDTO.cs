using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.DTO
{
    public class BookingDTO : BaseDTO
    {
        public int ClientId { get; set; }
        public int FlightId { get; set; }

    }
}
