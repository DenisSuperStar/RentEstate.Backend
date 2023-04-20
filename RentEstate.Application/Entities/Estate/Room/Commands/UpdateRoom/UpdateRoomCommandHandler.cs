using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Common.Exceptions;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Room.Commands.UpdateRoom
{
    public class UpdateRoomCommandHandler : IRequestHandler<UpdateRoomCommand, Unit>
    {
        private readonly IEstateDbContext _dbContext;

        public UpdateRoomCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Unit> Handle(UpdateRoomCommand updateRoomCommand, CancellationToken cancellationToken)
        {

            var findRoom = await _dbContext.Rooms.FirstOrDefaultAsync(f => f.EstateId == updateRoomCommand.EstateId, cancellationToken);

            if (findRoom is null || findRoom.UserId != updateRoomCommand.UserId) {
                throw new NotFoundException(nameof(Room), updateRoomCommand.EstateId);
            }

            findRoom.DatePublish = DateTime.UtcNow;
            findRoom.IsRent = updateRoomCommand.IsRent;
            findRoom.IsSale = updateRoomCommand.IsSale;
            findRoom.IsResident = updateRoomCommand.IsResident;
            findRoom.IsCommercial = updateRoomCommand.IsCommercial;
            findRoom.IsPet = updateRoomCommand.IsPet;
            findRoom.IsChildren = updateRoomCommand.IsChildren;
            findRoom.IsKitchen = updateRoomCommand.IsKitchen;
            findRoom.HasRepair = updateRoomCommand.HasRepair;
            findRoom.RepairType = updateRoomCommand.RepairType;
            findRoom.VideoUrl = updateRoomCommand.VideoUrl;
            findRoom.TitleAd = updateRoomCommand.TitleAd;
            findRoom.DescriptionAd = updateRoomCommand.DescriptionAd;
            findRoom.Payment = updateRoomCommand.Payment;
            findRoom.PaymentOwner = updateRoomCommand.PaymentOwner;
            findRoom.IsPaymentOwner = updateRoomCommand.IsPaymentOwner;
            findRoom.PaymentEarly = updateRoomCommand.PaymentEarly;
            findRoom.IsFridge = updateRoomCommand.IsFridge;
            findRoom.IsDishwasher = updateRoomCommand.IsDishwasher;
            findRoom.IsWashMachine = updateRoomCommand.IsWashMachine;
            findRoom.IsTV = updateRoomCommand.IsTV;
            findRoom.IsTelephone = updateRoomCommand.IsTelephone;
            findRoom.IsInternet = updateRoomCommand.IsInternet;
            findRoom.IsShower = updateRoomCommand.IsShower;
            findRoom.Address = updateRoomCommand.Address;
            findRoom.IsFlat = updateRoomCommand.IsFlat;
            findRoom.IsApartments = updateRoomCommand.IsApartments;
            findRoom.CountRooms = updateRoomCommand.CountRooms;
            findRoom.IsPenthouse = updateRoomCommand.IsPenthouse;
            findRoom.IsElevator = updateRoomCommand.IsElevator;
            findRoom.ElevatorsCount = updateRoomCommand.ElevatorsCount;
            findRoom.TotalArea = updateRoomCommand.TotalArea;
            findRoom.Floor = updateRoomCommand.Floor;
            findRoom.FloorsInHouse = updateRoomCommand.FloorsInHouse;
            findRoom.IsFurniture = updateRoomCommand.IsFurniture;
            findRoom.HasWindowToYard = updateRoomCommand.HasWindowToYard;
            findRoom.HasWindowToStreet = updateRoomCommand.HasWindowToStreet;
            findRoom.IsBalcony = updateRoomCommand.IsBalcony;
            findRoom.IsLoggia = updateRoomCommand.IsLoggia;
            findRoom.IsSeparatedBathroom = updateRoomCommand.IsSeparatedBathroom;
            findRoom.IsRampant = updateRoomCommand.IsRampant;
            findRoom.IsGarbageChute = updateRoomCommand.IsGarbageChute;
            findRoom.Parking = updateRoomCommand.Parking;

            await _dbContext.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
