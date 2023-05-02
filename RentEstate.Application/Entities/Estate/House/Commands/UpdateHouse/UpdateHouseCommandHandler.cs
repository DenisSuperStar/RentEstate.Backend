
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.House.Commands.UpdateHouse
{
    public class UpdateHouseCommandHandler : IRequestHandler<UpdateHouseCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateHouseCommand updateHouseCommand, CancellationToken cancellationToken)
        {
            var findHouse = await _dbContext.Houses.FirstOrDefaultAsync(f => f.EstateId == updateHouseCommand.EstateId, cancellationToken);

            if (findHouse is null || findHouse.UserId != updateHouseCommand.UserId) {
                throw new NotFoundException(nameof(House), updateHouseCommand.EstateId);
            }

            findHouse.DatePublish = DateTime.UtcNow;
            findHouse.IsRent = updateHouseCommand.IsRent;
            findHouse.IsSale = updateHouseCommand.IsSale;
            findHouse.IsResident = updateHouseCommand.IsResident;
            findHouse.IsCommercial = updateHouseCommand.IsCommercial;
            findHouse.IsPet = updateHouseCommand.IsPet;
            findHouse.IsChildren = updateHouseCommand.IsChildren;
            findHouse.IsKitchen = updateHouseCommand.IsKitchen;
            findHouse.HasRepair = updateHouseCommand.HasRepair;
            findHouse.RepairType = updateHouseCommand.RepairType;
            findHouse.VideoUrl = updateHouseCommand.VideoUrl;
            findHouse.TitleAd = updateHouseCommand.TitleAd;
            findHouse.DescriptionAd = updateHouseCommand.DescriptionAd;
            findHouse.Payment = updateHouseCommand.Payment;
            findHouse.PaymentOwner = updateHouseCommand.PaymentOwner;
            findHouse.IsPaymentOwner = updateHouseCommand.IsPaymentOwner;
            findHouse.PaymentEarly = updateHouseCommand.PaymentEarly;
            findHouse.IsFridge = updateHouseCommand.IsFridge;
            findHouse.IsDishwasher = updateHouseCommand.IsDishwasher;
            findHouse.IsWashMachine = updateHouseCommand.IsWashMachine;
            findHouse.IsTV = updateHouseCommand.IsTV;
            findHouse.IsTelephone = updateHouseCommand.IsTelephone;
            findHouse.IsInternet = updateHouseCommand.IsInternet;
            findHouse.IsBathroom = updateHouseCommand.IsBathroom;
            findHouse.IsShower = updateHouseCommand.IsShower;
            findHouse.Address = updateHouseCommand.Address;
            findHouse.LandPlotNumber = updateHouseCommand.LandPlotNumber;
            findHouse.CottageVillageNumber = updateHouseCommand.CottageVillageNumber;
            findHouse.ConstructYear = updateHouseCommand.ConstructYear;
            findHouse.HouseMaterial = updateHouseCommand.HouseMaterial;
            findHouse.HouseArea = updateHouseCommand.HouseArea;
            findHouse.FloorCount = updateHouseCommand.FloorCount;
            findHouse.BedroomNumber = updateHouseCommand.BedroomNumber;
            findHouse.ToiletOutdoors = updateHouseCommand.ToiletOutdoors;
            findHouse.ShowerOutdoors = updateHouseCommand.ShowerOutdoors;
            findHouse.Heating = updateHouseCommand.Heating;
            findHouse.HasFurnitureInRooms = updateHouseCommand.HasFurnitureInRooms;
            findHouse.HasFurnitureKitchen = updateHouseCommand.HasFurnitureKitchen;
            findHouse.HasGarage = updateHouseCommand.HasGarage;
            findHouse.HasPool = updateHouseCommand.HasPool;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
