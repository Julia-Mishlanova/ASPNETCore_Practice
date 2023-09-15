using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Domain
{
    public class Flight : BaseEntity
    {
        [AllowNull]
        public int FlightStatusId { get; set; }

        [ForeignKey("FlightStatusId")]
        public FlightStatus FlightStatus { get; set; }
    }
}
