using DeliverySystemV1._1.Models;
using Microsoft.EntityFrameworkCore;

namespace DeliverySystemV1._1.Seeds
{
    public class DbInitializer
    {
        private readonly ModelBuilder modelBuilder;

        public DbInitializer(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }
       
            public void Seed()
            {
                modelBuilder.Entity<CargoShipments>().HasData(
                     new CargoShipments { SenderId = 1, ShipmentId = 2, RecipientId = 3, TargetCargoAddress="Ankara" },
                     new CargoShipments { SenderId = 3, ShipmentId = 4, RecipientId = 4, TargetCargoAddress="İstanbul" }


                );
            }

        }
}
