using System.ComponentModel.DataAnnotations;

namespace DeliverySystemV1._1.Models
{
    public class Customer
    {
        [Key]

        public int DeliveryID { get; set; }

        public string CustomerName { get; set; } = string.Empty;

        public string CustomerSurname { get; set; } = string.Empty;

        public int TcIdentificationNumber { get; set; }

        public int Phone { get; set; }

        public string Address { get; set; } = string.Empty;

        public short  CustomerType { get; set; }

    }
}
