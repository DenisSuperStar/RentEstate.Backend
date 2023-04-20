
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Flat.Commands.UpdateFlat
{
    public class UpdateFlatCommandHandler : IRequestHandler<UpdateFlatCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateFlatCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateFlatCommand updateFlatCommand, CancellationToken cancellationToken)
        {

            var findFlat = await _dbContext.Flats.FirstOrDefaultAsync(f => f.EstateId == updateFlatCommand.EstateId, cancellationToken);

            if (findFlat is null || findFlat.UserId != updateFlatCommand.UserId) {
                throw new NotFoundException(nameof(Flat), updateFlatCommand.EstateId);
            }

            findFlat.DatePublish = DateTime.UtcNow;
            findFlat.IsRent = updateFlatCommand.IsRent;
            findFlat.IsSale = updateFlatCommand.IsSale;
            findFlat.IsResident = updateFlatCommand.IsResident;
            findFlat.IsCommercial = updateFlatCommand.IsCommercial;
            findFlat.IsPet = updateFlatCommand.IsPet;
            findFlat.IsChildren = updateFlatCommand.IsChildren;
            findFlat.IsKitchen = updateFlatCommand.IsKitchen;
            findFlat.HasRepair = updateFlatCommand.HasRepair;
            findFlat.RepairType = updateFlatCommand.RepairType;
            findFlat.VideoUrl = updateFlatCommand.VideoUrl;
            findFlat.TitleAd = updateFlatCommand.TitleAd;
            findFlat.DescriptionAd = updateFlatCommand.DescriptionAd;
            findFlat.Payment = updateFlatCommand.Payment;
            findFlat.PaymentOwner = updateFlatCommand.PaymentOwner;
            findFlat.IsPaymentOwner = updateFlatCommand.IsPaymentOwner;
            findFlat.PaymentEarly = updateFlatCommand.PaymentEarly;
            findFlat.IsFridge = updateFlatCommand.IsFridge;
            findFlat.IsDishwasher = updateFlatCommand.IsDishwasher;
            findFlat.IsWashMachine = updateFlatCommand.IsWashMachine;
            findFlat.IsTV = updateFlatCommand.IsTV;
            findFlat.IsTelephone = updateFlatCommand.IsTelephone;
            findFlat.IsInternet = updateFlatCommand.IsInternet;
            findFlat.IsShower = updateFlatCommand.IsShower;
            findFlat.Address = updateFlatCommand.Address;
            findFlat.IsFlat = updateFlatCommand.IsFlat;
            findFlat.IsApartments = updateFlatCommand.IsApartments;
            findFlat.CountRooms = updateFlatCommand.CountRooms;
            findFlat.IsPenthouse = updateFlatCommand.IsPenthouse;
            findFlat.IsElevator = updateFlatCommand.IsElevator;
            findFlat.ElevatorsCount = updateFlatCommand.ElevatorsCount;
            findFlat.TotalArea = updateFlatCommand.TotalArea;
            findFlat.Floor = updateFlatCommand.Floor;
            findFlat.FloorsInHouse = updateFlatCommand.FloorsInHouse;
            findFlat.IsFurniture = updateFlatCommand.IsFurniture;
            findFlat.HasWindowToYard = updateFlatCommand.HasWindowToYard;
            findFlat.HasWindowToStreet = updateFlatCommand.HasWindowToStreet;
            findFlat.IsBalcony = updateFlatCommand.IsBalcony;
            findFlat.IsLoggia = updateFlatCommand.IsLoggia;
            findFlat.IsSeparatedBathroom = updateFlatCommand.IsSeparatedBathroom;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
