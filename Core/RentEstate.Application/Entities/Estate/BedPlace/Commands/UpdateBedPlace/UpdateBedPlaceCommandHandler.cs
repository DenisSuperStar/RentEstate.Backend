
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.BedPlace.Commands.UpdateBedPlace
{
    public class UpdateBedPlaceCommandHandler : IRequestHandler<UpdateBedPlaceCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateBedPlaceCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateBedPlaceCommand updatePlaceCommand, CancellationToken cancellationToken)
        {
            var findBedPlace = await _dbContext.BedPlaces.FirstOrDefaultAsync(f => f.EstateId == updatePlaceCommand.EstateId, cancellationToken);

            if (findBedPlace is null || findBedPlace.UserId != updatePlaceCommand.UserId) {
                throw new NotFoundException(nameof(BedPlace), updatePlaceCommand.EstateId);
            }

            findBedPlace.DatePublish = DateTime.UtcNow;
            findBedPlace.IsRent = updatePlaceCommand.IsRent;
            findBedPlace.IsSale = updatePlaceCommand.IsSale;
            findBedPlace.IsResident = updatePlaceCommand.IsResident;
            findBedPlace.IsCommercial = updatePlaceCommand.IsCommercial;
            findBedPlace.IsPet = updatePlaceCommand.IsPet;
            findBedPlace.IsChildren = updatePlaceCommand.IsChildren;
            findBedPlace.IsKitchen = updatePlaceCommand.IsKitchen;
            findBedPlace.HasRepair = updatePlaceCommand.HasRepair;
            findBedPlace.RepairType = updatePlaceCommand.RepairType;
            findBedPlace.VideoUrl = updatePlaceCommand.VideoUrl;
            findBedPlace.TitleAd = updatePlaceCommand.TitleAd;
            findBedPlace.DescriptionAd = updatePlaceCommand.DescriptionAd;
            findBedPlace.Payment = updatePlaceCommand.Payment;
            findBedPlace.PaymentOwner = updatePlaceCommand.PaymentOwner;
            findBedPlace.IsPaymentOwner = updatePlaceCommand.IsPaymentOwner;
            findBedPlace.PaymentEarly = updatePlaceCommand.PaymentEarly;
            findBedPlace.IsFridge = updatePlaceCommand.IsFridge;
            findBedPlace.IsDishwasher = updatePlaceCommand.IsDishwasher;
            findBedPlace.IsWashMachine = updatePlaceCommand.IsWashMachine;
            findBedPlace.IsTV = updatePlaceCommand.IsTV;
            findBedPlace.IsTelephone = updatePlaceCommand.IsTelephone;
            findBedPlace.IsShower = updatePlaceCommand.IsShower;
            findBedPlace.Address = updatePlaceCommand.Address;
            findBedPlace.IsFlat = updatePlaceCommand.IsFlat;
            findBedPlace.IsApartments = updatePlaceCommand.IsApartments;
            findBedPlace.CountRooms = updatePlaceCommand.CountRooms;
            findBedPlace.IsPenthouse = updatePlaceCommand.IsPenthouse;
            findBedPlace.IsElevator = updatePlaceCommand.IsElevator;
            findBedPlace.ElevatorsCount = updatePlaceCommand.ElevatorsCount;
            findBedPlace.TotalArea = updatePlaceCommand.TotalArea;
            findBedPlace.Floor = updatePlaceCommand.Floor;
            findBedPlace.FloorsInHouse = updatePlaceCommand.FloorsIntHouse;
            findBedPlace.IsFurniture = updatePlaceCommand.IsFurniture;
            findBedPlace.HasWindowToYard = updatePlaceCommand.HasWindowToYard;
            findBedPlace.HasWindowToStreet = updatePlaceCommand.HasWindowToStreet;
            findBedPlace.IsBalcony = updatePlaceCommand.IsBalcony;
            findBedPlace.IsLoggia = updatePlaceCommand.IsLoggia;
            findBedPlace.IsSeparatedBathroom = updatePlaceCommand.IsSeparatedBathroom;
            findBedPlace.IsRampant = updatePlaceCommand.IsRampant;
            findBedPlace.IsGarbageChute = updatePlaceCommand.IsGarbageChute;
            findBedPlace.Parking = updatePlaceCommand.Parking;


            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
