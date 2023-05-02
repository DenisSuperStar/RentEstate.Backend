using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using RentEstate.Application.Entities.Interfaces;

namespace RentEstate.Application.Entities.Estate.Tawnhouse.Queries
{
    public class TawnhouseListQueryHandler : IRequestHandler<TawnhouseListQuery, TawnhouseListVm>
    {
        private readonly IEstateDbContext _dbContext;
        private readonly IMapper _mapper;

        public TawnhouseListQueryHandler(IEstateDbContext dbContext, IMapper mapper) {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<TawnhouseListVm> Handle(TawnhouseListQuery request, CancellationToken cancellationToken)
        {
            var tawnhouseQuery = await _dbContext.Tawnhouses
                .Where(search => search.UserId == request.UserId)
                .ProjectTo<TawnhouseListDTO>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);

            return new TawnhouseListVm { TawnhouseList = tawnhouseQuery };
        }
    }
}
