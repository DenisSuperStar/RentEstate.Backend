using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Room.Queries.RoomListQuery
{
    public class RoomListQueryHandler : IRequestHandler<RoomListQuery, RoomListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public RoomListQueryHandler(IEstateDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<RoomListVm> Handle(RoomListQuery request, CancellationToken cancellationToken)
        {
            var roomQuery = await _dbContext.Rooms
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<RoomListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new RoomListVm { RoomList = roomQuery };
        }
    }
}
