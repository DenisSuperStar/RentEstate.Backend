using MediatR;

namespace RentEstate.Application.Entities.Estate.BedPlace.Commands.DeleteBedPlace
{
    public class DeleteBedPlaceCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid EstateId { get; set; }
    }
}
