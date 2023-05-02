using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentEstate.Domain;

namespace RentEstate.Persistance.EntityTypeConfiguration
{
    public class HouseConfiguration : IEntityTypeConfiguration<House>
    {
        public void Configure(EntityTypeBuilder<House> builder)
        {
            builder.Property(prop => prop.IsRent).IsRequired();
            builder.Property(prop => prop.IsSale).IsRequired();
            builder.Property(prop => prop.IsResident).IsRequired();
            builder.Property(prop => prop.IsCommercial).IsRequired();
            builder.Property(prop => prop.IsPet).IsRequired();
            builder.Property(prop => prop.IsChildren).IsRequired();
            builder.Property(prop => prop.IsBathroom).IsRequired();
            builder.Property(prop => prop.IsShower).IsRequired();
            builder.Property(prop => prop.Address).IsRequired();
            builder.Property(prop => prop.HouseArea).IsRequired();
            builder.Property(prop => prop.FloorCount).IsRequired();
            builder.Property(prop => prop.BedroomNumber).IsRequired();
            builder.Property(prop => prop.ToiletOutdoors).IsRequired();
            builder.Property(prop => prop.ShowerOutdoors).IsRequired();
            builder.Property(prop => prop.Heating).IsRequired();
            builder.Property(prop => prop.HasFurnitureInRooms).IsRequired();
            builder.Property(prop => prop.HasFurnitureKitchen).IsRequired();
            builder.Property(prop => prop.Payment).IsRequired();
            builder.Property(prop => prop.PaymentEarly).IsRequired();
        }
    }
}
