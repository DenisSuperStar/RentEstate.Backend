using Microsoft.EntityFrameworkCore;

namespace RentEstate.Application.Entities.Interfaces
{
    public interface IEstateDbContext
    {
        DbSet<Domain.BedPlace> BedPlaces { get; set; }
        DbSet<Domain.Cottage> Cottages { get; set; }
        DbSet<Domain.Estate> Estates { get; set; }
        DbSet<Domain.Flat> Flats { get; set; }
        DbSet<Domain.House> Houses { get; set; }
        DbSet<Domain.PartOfHouse> PartOfHouses { get; set; }
        DbSet<Domain.Room> Rooms { get; set; }
        DbSet<Domain.Tawnhouse> Tawnhouses { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
