using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Booking : BaseEntity
    {
        [AllowNull]
        public int ClientId { get; set; }

        [ForeignKey("ClientId")]
        public Client Client { get; set; }

        

        [AllowNull]
        public int FlightSeatPriceId { get; set; }

        [ForeignKey("FlightSeatPriceId")]
        public FlightSeatPrice FlightSeatPrice { get; set; }
    }
}
