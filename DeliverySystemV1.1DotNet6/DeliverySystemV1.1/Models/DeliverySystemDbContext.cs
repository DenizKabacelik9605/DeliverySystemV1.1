using Microsoft.EntityFrameworkCore;
using DeliverySystemV1._1.Seeds;
namespace DeliverySystemV1._1.Models
{
    public class DeliverySystemDbContext:DbContext
    {
        public DeliverySystemDbContext(DbContextOptions<DeliverySystemDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            new DbInitializer(modelBuilder).Seed();
        }


        public DbSet<CargoShipments> CargoShipments { get; set; }

        public DbSet<CargoTrack> CargoTracks { get; set; }


        public DbSet<Customer> Customers { get; set; }  
        
        public DbSet<Product> Products { get; set; }

        public DbSet<Sender> Senders { get; set; }



    }
    }

