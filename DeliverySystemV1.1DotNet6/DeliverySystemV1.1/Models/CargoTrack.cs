using System.ComponentModel.DataAnnotations;

namespace DeliverySystemV1._1.Models
{
    public class CargoTrack
    {
        [Key]

        public int TrackId { get; set; }

        public int CargoShipmentId { get; set; }

        public string Location { get; set; } = string.Empty;

        public string Coordinate { get; set; } = string.Empty;

        public short Status { get; set; }

        public DateTime DepartureDateTime { get; set; }

        public string DeliveryDateTime { get; set; }
    }
}
