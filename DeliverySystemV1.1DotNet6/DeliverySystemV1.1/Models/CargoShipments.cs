using System.ComponentModel.DataAnnotations;

namespace DeliverySystemV1._1.Models
{
    public class CargoShipments
    {
        [Key]

        public int ShipmentId { get; set; }

        public int SenderId { get; set; }

        public int RecipientId { get; set; }

        public string TargetCargoAddress { get; set; }

        
    }
}