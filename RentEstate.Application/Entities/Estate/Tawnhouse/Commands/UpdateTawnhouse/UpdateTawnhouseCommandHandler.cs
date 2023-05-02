using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Commands.UpdateTawnhouse
{
    public class UpdateTawnHouseCommandHandler : IRequestHandler<UpdateTawnHouseCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateTawnHouseCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateTawnHouseCommand updateTawnhouseCommand, CancellationToken cancellationToken)
        {
            var findTawhouse = await _dbContext.Tawnhouses.FirstOrDefaultAsync(f => f.EstateId == updateTawnhouseCommand.EstateId, cancellationToken);

            if (findTawhouse is null || findTawhouse.UserId != updateTawnhouseCommand.UserId) {
                throw new NotFoundException(nameof(Tawnhouse), updateTawnhouseCommand.EstateId);
            }

            findTawhouse.DatePublish = DateTime.UtcNow;
            findTawhouse.IsRent = updateTawnhouseCommand.IsRent;
            findTawhouse.IsSale = updateTawnhouseCommand.IsSale;
            findTawhouse.IsResident = updateTawnhouseCommand.IsResident;
            findTawhouse.IsCommercial = updateTawnhouseCommand.IsCommercial;
            findTawhouse.IsPet = updateTawnhouseCommand.IsPet;
            findTawhouse.IsChildren = updateTawnhouseCommand.IsChildren;
            findTawhouse.IsKitchen = updateTawnhouseCommand.IsKitchen;
            findTawhouse.HasRepair = updateTawnhouseCommand.HasRepair;
            findTawhouse.RepairType = updateTawnhouseCommand.RepairType;
            findTawhouse.VideoUrl = updateTawnhouseCommand.VideoUrl;
            findTawhouse.TitleAd = updateTawnhouseCommand.TitleAd;
            findTawhouse.DescriptionAd = updateTawnhouseCommand.DescriptionAd;
            findTawhouse.Payment = updateTawnhouseCommand.Payment;
            findTawhouse.PaymentOwner = updateTawnhouseCommand.PaymentOwner;
            findTawhouse.IsPaymentOwner = updateTawnhouseCommand.IsPaymentOwner;
            findTawhouse.PaymentEarly = updateTawnhouseCommand.PaymentEarly;
            findTawhouse.IsFridge = updateTawnhouseCommand.IsFridge;
            findTawhouse.IsDishwasher = updateTawnhouseCommand.IsDishwasher;
            findTawhouse.IsWashMachine = updateTawnhouseCommand.IsWashMachine;
            findTawhouse.IsTV = updateTawnhouseCommand.IsTV;
            findTawhouse.IsTelephone = updateTawnhouseCommand.IsTelephone;
            findTawhouse.IsInternet = updateTawnhouseCommand.IsInternet;
            findTawhouse.IsBathroom = updateTawnhouseCommand.IsBathroom;
            findTawhouse.IsShower = updateTawnhouseCommand.IsShower;
            findTawhouse.Address = updateTawnhouseCommand.Address;
            findTawhouse.LandPlotNumber = updateTawnhouseCommand.LandPlotNumber;
            findTawhouse.CottageVillageNumber = updateTawnhouseCommand.CottageVillageNumber;
            findTawhouse.ConstructYear = updateTawnhouseCommand.ConstructYear;
            findTawhouse.HouseMaterial = updateTawnhouseCommand.HouseMaterial;
            findTawhouse.HouseArea = updateTawnhouseCommand.HouseArea;
            findTawhouse.FloorCount = updateTawnhouseCommand.FloorCount;
            findTawhouse.BedroomNumber = updateTawnhouseCommand.BedroomNumber;
            findTawhouse.ToiletOutdoors = updateTawnhouseCommand.ToiletOutdoors;
            findTawhouse.ShowerOutdoors = updateTawnhouseCommand.ShowerOutdoors;
            findTawhouse.Heating = updateTawnhouseCommand.Heating;
            findTawhouse.HasFurnitureInRooms = updateTawnhouseCommand.HasFurnitureInRooms;
            findTawhouse.HasFurnitureKitchen = updateTawnhouseCommand.HasFurnitureKitchen;
            findTawhouse.HasGarage = updateTawnhouseCommand.HasGarage;
            findTawhouse.HasPool = updateTawnhouseCommand.HasPool;
            findTawhouse.HasSelfEmployed = updateTawnhouseCommand.HasSelfEmployed;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
