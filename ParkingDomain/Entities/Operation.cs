using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingDomain.Entities
{
    public class Operation: BaseEntity
    {     
      
        public DateTime EntryDate { get; set; }
        public DateTime DepartureDate { get; set; }
        public TimeSpan HoursSpent { get; set; }
        [Column(TypeName ="decimal(4,2)")]
        public decimal ValuePaid { get; set; }
        public Guid VehicleId { get; set; }
        public Guid ParkingSpotId { get; set; }
    }
}
