using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.PartOfHouse.Commands.UpdatePartOfHouse
{
    public class UpdatePartOfHouseCommandHandler : IRequestHandler<UpdatePartOfHouseCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdatePartOfHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdatePartOfHouseCommand updateHousePartCommand, CancellationToken cancellationToken)
        {
            var findPartOfHouse = await _dbContext.PartOfHouses.FirstOrDefaultAsync(f => f.EstateId == updateHousePartCommand.EstateId, cancellationToken);

            if (findPartOfHouse is null || findPartOfHouse.UserId != updateHousePartCommand.UserId) {
                throw new NotFoundException(nameof(PartOfHouse), updateHousePartCommand.EstateId);
            }

            findPartOfHouse.DatePublish = DateTime.UtcNow;
            findPartOfHouse.IsRent = updateHousePartCommand.IsRent;
            findPartOfHouse.IsSale = updateHousePartCommand.IsSale;
            findPartOfHouse.IsResident = updateHousePartCommand.IsResident;
            findPartOfHouse.IsCommercial = updateHousePartCommand.IsCommercial;
            findPartOfHouse.IsPet = updateHousePartCommand.IsPet;
            findPartOfHouse.IsChildren = updateHousePartCommand.IsChildren;
            findPartOfHouse.IsKitchen = updateHousePartCommand.IsKitchen;
            findPartOfHouse.HasRepair = updateHousePartCommand.HasRepair;
            findPartOfHouse.RepairType = updateHousePartCommand.RepairType;
            findPartOfHouse.VideoUrl = updateHousePartCommand.VideoUrl;
            findPartOfHouse.TitleAd = updateHousePartCommand.TitleAd;
            findPartOfHouse.DescriptionAd = updateHousePartCommand.DescriptionAd;
            findPartOfHouse.Payment = updateHousePartCommand.Payment;
            findPartOfHouse.PaymentOwner = updateHousePartCommand.PaymentOwner;
            findPartOfHouse.IsPaymentOwner = updateHousePartCommand.IsPaymentOwner;
            findPartOfHouse.PaymentEarly = updateHousePartCommand.PaymentEarly;
            findPartOfHouse.IsFridge = updateHousePartCommand.IsFridge;
            findPartOfHouse.IsDishwasher = updateHousePartCommand.IsDishwasher;
            findPartOfHouse.IsWashMachine = updateHousePartCommand.IsWashMachine;
            findPartOfHouse.IsTV = updateHousePartCommand.IsTV;
            findPartOfHouse.IsTelephone = updateHousePartCommand.IsTelephone;
            findPartOfHouse.IsInternet = updateHousePartCommand.IsInternet;
            findPartOfHouse.IsBathroom = updateHousePartCommand.IsBathroom;
            findPartOfHouse.IsShower = updateHousePartCommand.IsShower;
            findPartOfHouse.Address = updateHousePartCommand.Address;
            findPartOfHouse.LandPlotNumber = updateHousePartCommand.LandPlotNumber;
            findPartOfHouse.CottageVillageNumber = updateHousePartCommand.CottageVillageNumber;
            findPartOfHouse.ConstructYear = updateHousePartCommand.ConstructYear;
            findPartOfHouse.HouseMaterial = updateHousePartCommand.HouseMaterial;
            findPartOfHouse.HouseArea = updateHousePartCommand.HouseArea;
            findPartOfHouse.FloorCount = updateHousePartCommand.FloorCount;
            findPartOfHouse.BedroomNumber = updateHousePartCommand.BedroomNumber;
            findPartOfHouse.ToiletOutdoors = updateHousePartCommand.ToiletOutdoors;
            findPartOfHouse.ShowerOutdoors = updateHousePartCommand.ShowerOutddors;
            findPartOfHouse.Heating = updateHousePartCommand.Heating;
            findPartOfHouse.HasFurnitureInRooms = updateHousePartCommand.HasFurnitureInRooms;
            findPartOfHouse.HasFurnitureKitchen = updateHousePartCommand.HasFurnitureKitchen;
            findPartOfHouse.HasGarage = updateHousePartCommand.HasGarage;
            findPartOfHouse.HasPool = updateHousePartCommand.HasPool;
            findPartOfHouse.PartForRent = updateHousePartCommand.PartForRent;
            findPartOfHouse.HasSelfEmployed = updateHousePartCommand.HasSelfEmployed;


            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
