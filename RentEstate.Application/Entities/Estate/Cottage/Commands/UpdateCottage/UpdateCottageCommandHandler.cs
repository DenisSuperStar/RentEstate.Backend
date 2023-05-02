using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Cottage.Commands.UpdateCottage
{
    public class UpdateCottageCommandHandler : IRequestHandler<UpdateCottageCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateCottageCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateCottageCommand updateCottageCommand, CancellationToken cancellationToken)
        {
            var findCottage = await _dbContext.Cottages.FirstOrDefaultAsync(f => f.EstateId == updateCottageCommand.EstateId, cancellationToken);

            if (findCottage is null || findCottage.UserId != updateCottageCommand.UserId) {
                throw new NotFoundException(nameof(Cottage), updateCottageCommand.EstateId);
            }

            findCottage.DatePublish = DateTime.UtcNow;
            findCottage.IsRent = updateCottageCommand.IsRent;
            findCottage.IsSale = updateCottageCommand.IsSale;
            findCottage.IsResident = updateCottageCommand.IsResident;
            findCottage.IsCommercial = updateCottageCommand.IsCommercial;
            findCottage.IsPet = updateCottageCommand.IsPet;
            findCottage.IsChildren = updateCottageCommand.IsChildren;
            findCottage.IsKitchen = updateCottageCommand.IsKitchen;
            findCottage.HasRepair = updateCottageCommand.HasRepair;
            findCottage.RepairType = updateCottageCommand.RepairType;
            findCottage.VideoUrl = updateCottageCommand.VideoUrl;
            findCottage.TitleAd = updateCottageCommand.TitleAd;
            findCottage.DescriptionAd = updateCottageCommand.DescriptionAd;
            findCottage.Payment = updateCottageCommand.Payment;
            findCottage.PaymentOwner = updateCottageCommand.PaymentOwner;
            findCottage.IsPaymentOwner = updateCottageCommand.IsPaymentOwner;
            findCottage.PaymentEarly = updateCottageCommand.PaymentEarly;
            findCottage.IsFridge = updateCottageCommand.IsFridge;
            findCottage.IsDishwasher = updateCottageCommand.IsDishwasher;
            findCottage.IsWashMachine = updateCottageCommand.IsWashMachine;
            findCottage.IsTV = updateCottageCommand.IsTV;
            findCottage.IsTelephone = updateCottageCommand.IsTelephone;
            findCottage.IsInternet = updateCottageCommand.IsInternet;
            findCottage.IsBathroom = updateCottageCommand.IsBathroom;
            findCottage.IsShower = updateCottageCommand.IsShower;
            findCottage.Address = updateCottageCommand.Address;
            findCottage.LandPlotNumber = updateCottageCommand.LandPlotNumber;
            findCottage.CottageVillageNumber = updateCottageCommand.CottageVillageNumber;
            findCottage.ConstructYear = updateCottageCommand.ConstructYear;
            findCottage.HouseMaterial = updateCottageCommand.HouseMaterial;
            findCottage.HouseArea = updateCottageCommand.HouseArea;
            findCottage.FloorCount = updateCottageCommand.FloorCount;
            findCottage.BedroomNumber = updateCottageCommand.BedroomNumber;
            findCottage.ToiletOutdoors = updateCottageCommand.ToiletOutdoors;
            findCottage.ShowerOutdoors = updateCottageCommand.ShowerOutdoors;
            findCottage.Heating = updateCottageCommand.Heating;
            findCottage.HasFurnitureInRooms = updateCottageCommand.HasFurnitureInRooms;
            findCottage.HasFurnitureKitchen = updateCottageCommand.HasFurnitureKitchen;
            findCottage.HasGarage = updateCottageCommand.HasGarage;
            findCottage.HasPool = updateCottageCommand.HasPool;
            findCottage.HasSelfEmployed = updateCottageCommand.HasSelfEmployed;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
