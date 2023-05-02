using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Flat.Commands.CreateFlat
{
    public class CreateFlatCommandHandler : IRequestHandler<CreateFlatCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;

        public CreateFlatCommandHandler(IEstateDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateFlatCommand request, CancellationToken cancellationToken)
        {
            var flat = new Domain.Flat
            {
                UserId = request.UserId,
                EstateId = Guid.NewGuid(),
                DatePublish = DateTime.UtcNow,
                IsPublish = request.IsPublish,
                IsRent = request.IsRent,
                IsSale = request.IsSale,
                IsResident = request.IsResident,
                IsCommercial = request.IsCommercial,
                IsPet = request.IsPet,
                IsChildren = request.IsChildren,
                IsKitchen = request.IsKitchen,
                HasRepair = request.HasRepair,
                RepairType = request.RepairType,
                VideoUrl = request.VideoUrl,
                TitleAd = request.TitleAd,
                DescriptionAd = request.DescriptionAd,
                Payment = request.Payment,
                PaymentOwner = request.PaymentOwner,
                IsPaymentOwner = request.IsPaymentOwner,
                PaymentEarly = request.PaymentEarly,
                IsFridge = request.IsFridge,
                IsDishwasher = request.IsDishwasher,
                IsWashMachine = request.IsWashMachine,
                IsTV = request.IsTV,
                IsTelephone = request.IsTelephone,
                IsInternet = request.IsInternet,
                IsBathroom = request.IsBathroom,
                IsShower = request.IsShower,
                Address = request.Address,
                IsFlat = request.IsFlat,
                IsApartments = request.IsApartments,
                CountRooms = request.CountRooms,
                IsPenthouse = request.IsPenthouse,
                IsElevator = request.IsElevator,
                ElevatorsCount = request.ElevatorsCount,
                TotalArea = request.TotalArea,
                Floor = request.Floor,
                FloorsInHouse = request.FloorsInHouse,
                IsFurniture = request.IsFurniture,
                HasWindowToYard = request.HasWindowToYard,
                HasWindowToStreet = request.HasWindowToStreet,
                IsBalcony = request.IsBalcony,
                IsLoggia = request.IsLoggia,
                IsSeparatedBathroom = request.IsSeparatedBathroom
            };

            await _dbContext.Flats.AddAsync(flat, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return flat.EstateId;
        }
    }
}
