using AutoMapper;
using Internship.Controllers.ProductXAttributes.Models;
using Internship.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Internship.Business.ProductXAttributes.Queries.Filter
{
    public class GetAllProductXAttributeHandler : IRequestHandler<GetAllProductXAttributeQuery, List<ProductXAttribute>>
    {
        private EcomDbContext _dbContext;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public GetAllProductXAttributeHandler(EcomDbContext dbContext, IMapper mapper, IMediator mediator)
        {
            _dbContext = dbContext;
            _mapper = mapper;
            _mediator = mediator;
        }
        public async Task<List<ProductXAttribute>> Handle(GetAllProductXAttributeQuery request, CancellationToken cancellationToken)
        {
            var products = await _dbContext.ProductXAttributes.Include(x => x.Product).Include(x => x.Attribute).ToListAsync();
            return products;
        }
    }
}
