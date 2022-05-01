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
    public class Vehicle : BaseEntity
    {
        [MaxLength(10)]
        public string Plate { get; set; }
        [MaxLength(15)]
        public VehicleSize VehicleSize { get; set; }
        public List<Operation> Operation { get; set; }
    }
}
