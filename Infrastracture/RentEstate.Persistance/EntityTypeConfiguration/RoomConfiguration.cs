using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentEstate.Domain;

namespace RentEstate.Persistance.EntityTypeConfiguration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(prop => prop.IsRent).IsRequired();
            builder.Property(prop => prop.IsSale).IsRequired();
            builder.Property(prop => prop.IsResident).IsRequired();
            builder.Property(prop => prop.IsCommercial).IsRequired();
            builder.Property(prop => prop.IsPet).IsRequired();
            builder.Property(prop => prop.IsChildren).IsRequired();
            builder.Property(prop => prop.HasRepair).IsRequired();
            builder.Property(prop => prop.RepairType).IsRequired();
            builder.Property(prop => prop.IsBathroom).IsRequired();
            builder.Property(prop => prop.IsShower).IsRequired();
            builder.Property(prop => prop.DescriptionAd).IsRequired();
            builder.Property(prop => prop.Payment).IsRequired();
            builder.Property(prop => prop.PaymentEarly).IsRequired();
            builder.Property(prop => prop.IsFridge).IsRequired();
            builder.Property(prop => prop.IsWashMachine).IsRequired();
            builder.Property(prop => prop.Address).IsRequired();
            builder.Property(prop => prop.CountRooms).IsRequired();
            builder.Property(prop => prop.IsElevator).IsRequired();
            builder.Property(prop => prop.Floor).IsRequired();
            builder.Property(prop => prop.Parking).IsRequired();
        }
    }
}
