using MediatR;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Room.Commands.CreateRoom
{
    public class CreateRoomCommandHandler : IRequestHandler<CreateRoomCommand, Guid>
    {
        private readonly IEstateDbContext _dbContext;

        public CreateRoomCommandHandler(IEstateDbContext dbContext) {
            _dbContext = dbContext;
        }

        public async Task<Guid> Handle(CreateRoomCommand request, CancellationToken cancellationToken)
        {
            var room = new Domain.Room
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
                IsFlat = request.IsFlat,
                IsApartments = request.IsApartments,
                CountRooms = request.CountRooms,
                IsPenthouse = request.IsPenthouse,
                IsElevator = request.IsElevator,
                ElevatorsCount = request.ElevatorsCount,
                TotalArea = request.TotalArea,
                Floor = request.Floor,
                FloorsInHouse = request.FloorsInHouse,
                IsFurniture = request.IsFurniture,
                HasWindowToYard = request.HasWindowToYard,
                HasWindowToStreet = request.HasWindowToStreet,
                IsBalcony = request.IsBalcony,
                IsLoggia = request.IsLoggia,
                IsSeparatedBathroom = request.IsSeparatedBathroom,
                IsRampant = request.IsRampant,
                IsGarbageChute = request.IsGarbageChute,
                Parking = request.Parking
            };

            await _dbContext.Rooms.AddAsync(room, cancellationToken);
            await _dbContext.SaveChangesAsync(cancellationToken);

            return room.EstateId;
        }
    }
}
