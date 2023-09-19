using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Flight : BaseEntity
    {
        [AllowNull]
        public int ScheduleId { get; set; }

        [ForeignKey("ScheduleId")]
        public virtual Schedule Schedule { get; set; }

        [AllowNull]
        public int FlightStatusId { get; set; }

        [ForeignKey("FlightStatusId")]
        public virtual FlightStatus FlightStatus { get; set; }
    }
}
