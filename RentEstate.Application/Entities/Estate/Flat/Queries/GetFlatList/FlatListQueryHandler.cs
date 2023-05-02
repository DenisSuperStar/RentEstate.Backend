
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Flat.Queries.GetFlatList
{
    public class FlatListQueryHandler : IRequestHandler<FlatListQuery, FlatListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public FlatListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<FlatListVm> Handle(FlatListQuery request, CancellationToken cancellationToken)
        {
            var flatQuery = await _dbContext.Flats
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<FlatListDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new FlatListVm { FlatList = flatQuery };
        }
    }
}
