using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RentEstate.Domain;

namespace RentEstate.Persistance.EntityTypeConfiguration
{
    public class FlatConfiguration : IEntityTypeConfiguration<Flat>
    {
        public void Configure(EntityTypeBuilder<Flat> builder)
        {
            builder.Property(prop => prop.IsRent).IsRequired();
            builder.Property(prop => prop.IsSale).IsRequired();
            builder.Property(prop => prop.IsResident).IsRequired();
            builder.Property(prop => prop.IsCommercial).IsRequired();
            builder.Property(prop => prop.IsPet).IsRequired();
            builder.Property(prop => prop.IsChildren).IsRequired();
            builder.Property(prop => prop.HasRepair).IsRequired();
            builder.Property(prop => prop.RepairType).IsRequired();
            builder.Property(prop => prop.DescriptionAd).IsRequired();
            builder.Property(prop => prop.Address).IsRequired();
            builder.Property(prop => prop.Payment).IsRequired();
            builder.Property(prop => prop.PaymentEarly).IsRequired();
            builder.Property(prop => prop.IsFridge).IsRequired();
            builder.Property(prop => prop.IsWashMachine).IsRequired();
            builder.Property(prop => prop.IsBathroom).IsRequired();
            builder.Property(prop => prop.IsShower).IsRequired();
            builder.Property(prop => prop.IsFlat).IsRequired();
            builder.Property(prop => prop.IsApartments).IsRequired();
            builder.Property(prop => prop.CountRooms).IsRequired();
            builder.Property(prop => prop.IsElevator).IsRequired();
            builder.Property(prop => prop.Floor).IsRequired();
            builder.Property(prop => prop.IsFurniture).IsRequired();
            builder.Property(prop => prop.IsBalcony).IsRequired();
            builder.Property(prop => prop.IsLoggia).IsRequired();
        }
    }
}
