using Microsoft.EntityFrameworkCore;
using RentEstate.Domain;
using RentEstate.Application.Entities.Interfaces;
using RentEstate.Persistance.EntityTypeConfiguration;
using System.Configuration;

namespace RentEstate.Persistance
{

    public class EstateDbContext : DbContext, IEstateDbContext
    {
        private const string EstateDBConnection = "Server=(localdb)\\mssqllocaldb;Database=Estate;Trusted_Connection=True;";

        public DbSet<BedPlace> BedPlaces { get; set; }
        public DbSet<Cottage> Cottages { get; set; }
        public DbSet<Estate> Estates { get; set; }
        public DbSet<Flat> Flats { get; set; }
        public DbSet<House> Houses { get; set; }
        public DbSet<PartOfHouse> PartOfHouses { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Tawnhouse> Tawnhouses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings[EstateDBConnection].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new BedPlaceConfiguration());
            modelBuilder.ApplyConfiguration(new CottageConfiguration());
            modelBuilder.ApplyConfiguration(new FlatConfiguration());
            modelBuilder.ApplyConfiguration(new HouseConfiguration());
            modelBuilder.ApplyConfiguration(new PartOfHouseConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
        }
    }
}
