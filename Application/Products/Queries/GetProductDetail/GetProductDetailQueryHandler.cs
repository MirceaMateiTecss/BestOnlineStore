﻿using Application.Common.Exceptions;
using Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Domain.Entites;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Queries.GetProductDetail
{
    public class GetProductDetailQueryHandler : MediatR.IRequestHandler<GetProductDetailQuery, ProductDetailVm>
    {
        private readonly IOnlineStoreDbContext _context;
        private readonly IMapper _mapper;

        public GetProductDetailQueryHandler(IOnlineStoreDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ProductDetailVm> Handle(GetProductDetailQuery request, CancellationToken cancellationToken)
        {
            var vm = await _context.Products
                .ProjectTo<ProductDetailVm>(_mapper.ConfigurationProvider)
                .FirstOrDefaultAsync(p => p.ProductId == request.Id, cancellationToken);

            if (vm == null)
            {
                throw new NotFoundException(nameof(Product), request.Id);
            }

            return vm;
        }
    }
}
