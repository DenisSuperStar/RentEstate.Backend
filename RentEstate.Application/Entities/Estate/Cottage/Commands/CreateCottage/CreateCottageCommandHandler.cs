using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Cottage.Commands.CreateCottage
{
    public class CreateCottageCommandHandler : IRequestHandler<CreateCottageCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;

        public CreateCottageCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateCottageCommand request, CancellationToken cancellationToken)
        {
            var cottage = new Domain.Cottage
            {
                UserId = request.UserId,
                EstateId = Guid.NewGuid(),
                DatePublish= DateTime.UtcNow,
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
                Heating = request.Heating,
                HasFurnitureInRooms = request.HasFurnitureInRooms,
                HasFurnitureKitchen = request.HasFurnitureKitchen,
                HasGarage = request.HasGarage,
                HasPool = request.HasPool,
                HasSelfEmployed = request.HasSelfEmployed
            };

            await _dbContext.Cottages.AddAsync(cottage, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return cottage.EstateId;
        }
    }
}
