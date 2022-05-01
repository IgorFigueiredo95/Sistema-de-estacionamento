using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ParkingDomain.Entities.EnumVehicleSize;

namespace ParkingDomain.Entities
{
    public class ParkingSpot: BaseEntity
    {
        [MaxLength(15)]
        public VehicleSize VehicleSize { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required, Column(TypeName ="decimal(4,2)")]
        public decimal PricePerHour { get; set; }
        public List<Operation> Operation { get; set; }
    }
}
