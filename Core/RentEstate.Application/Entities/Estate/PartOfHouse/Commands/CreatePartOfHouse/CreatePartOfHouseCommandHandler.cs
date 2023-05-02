using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Commands.CreatePartOfHouse
{
    public class CreatePartOfHouseCommandHandler : IRequestHandler<CreatePartOfHouseCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;

        public CreatePartOfHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreatePartOfHouseCommand request, CancellationToken cancellationToken) {
            var partOfHouse = new Domain.PartOfHouse
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
                IsPaymentOwner = request.IsPaymentOwner,
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
                Outdoors = request.Outdoors,
                Heating = request.Heating,
                HasFurnitureInRooms = request.HasFurnitureInRooms,
                HasFurnitureKitchen = request.HasFurnitureKitchen,
                HasBathOutdoors = request.HasBathOutdoors,
                HasGarage = request.HasGarage,
                HasPool = request.HasPool,

                PartForRent = request.PartForRent,
                HasSelfEmployed = request.HasSelfEmployed
            };

            await _dbContext.PartOfHouses.AddAsync(partOfHouse, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return partOfHouse.EstateId;
        }
    }
}
