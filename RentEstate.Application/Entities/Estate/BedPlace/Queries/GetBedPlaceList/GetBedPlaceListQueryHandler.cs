using MediatR;
using AutoMapper;
using RentEstate.Application.Entities.Interfaces;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace RentEstate.Application.Entities.Estate.BedPlace.Queries.GetBedPlaceList
{
    public class GetBedPlaceListQueryHandler : IRequestHandler<GetBedPlaceListQuery, BedPlaceListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public GetBedPlaceListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<BedPlaceListVm> Handle(GetBedPlaceListQuery request, CancellationToken cancellationToken)
        {
            var bedPlacesQuery = await _dbContext.BedPlaces
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<BedPlaceListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new BedPlaceListVm { PlaceList = bedPlacesQuery };
        }
    }
}
