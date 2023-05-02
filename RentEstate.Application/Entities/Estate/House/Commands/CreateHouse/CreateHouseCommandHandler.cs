using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.House.Commands.CreateHouse
{
    public class CreateHouseCommandHandler : IRequestHandler<CreateHouseCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;
        public CreateHouseCommandHandler(IEstateDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<Guid> Handle(CreateHouseCommand request, CancellationToken cancellationToken)
        {
            var house = new Domain.House
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
                LandPlotNumber = request.LandPlotNumber,
                CottageVillageNumber = request.CottageVillageNumber,
                ConstructYear = request.ConstructYear,
                HouseMaterial = request.HouseMaterial,
                HouseArea = request.HouseArea,
                FloorCount = request.FloorCount,
                BedroomNumber = request.BedroomNumber,
                ToiletOutdoors = request.ToiletOutdoors,
                ShowerOutdoors = request.ShowerOutdoors,
                HasFurnitureInRooms = request.HasFurnitureInRooms,
                HasFurnitureKitchen = request.HasFurnitureKitchen,
                HasGarage = request.HasGarage,
                HasPool = request.HasPool
            };

            await _dbContext.Houses.AddAsync(house, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return house.EstateId;
        }
    }
}
