using System.ComponentModel.DataAnnotations;

namespace DeliverySystemV1._1.Models
{
    public class Product
    {
        [Key]

        public int ProductId { get; set; }

        public string Name { get; set; } = string.Empty;

        public int Weightiness { get; set; }

        public string Dimension { get; set; }
    }
}
