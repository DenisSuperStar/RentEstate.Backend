using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Commands.CreateTawnhouse
{
    public class CreateTawnhouseCommandHandler : IRequestHandler<CreateTawnhouseCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;

        public CreateTawnhouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateTawnhouseCommand request, CancellationToken cancellationToken) {

            var tawnHouse = new Domain.Tawnhouse
            {
                EstateId = Guid.NewGuid(),
                DatePublish = DateTime.UtcNow,
                IsPublish = request.IsPublish,
                IsRent = request.IsRent,
                IsSale = request.IsSale,
                IsResident = request.IsResident,
                IsCommercial = request.IsCommercial,
                IsPet = request.IsPet,
                IsChildren = request.IsChildren,
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
                Heating = request.Heating,
                HasFurnitureInRooms = request.HasFurnitureInRooms,
                HasFurnitureKitchen = request.HasFurnitureKitchen,
                HasGarage = request.HasGarage,
                HasPool = request.HasPool,
                HasSelfEmployed = request.HasSelfEmployed
            };

            await _dbContext.Estates.AddAsync(tawnHouse, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return tawnHouse.EstateId;
        }
    }
}
