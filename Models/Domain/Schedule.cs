using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASPNETCore_Practice.Models.Domain
{
    public class Schedule : BaseEntity
    {
        [AllowNull]
        public int DirectionId { get; set; }

        [ForeignKey("DirectionId")]
        public virtual Direction Direction { get; set; }

        public DateTime DepartureTimeGMT { get; set; }

        public DateTime ArrivalTimeGMT { get; set; }
    }
}
