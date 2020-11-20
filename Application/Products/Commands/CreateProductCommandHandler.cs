using Application.Common.Interfaces;
using Domain.Entites;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Products.Commands
{
    public class CreateProductCommandHandler : IRequestHandler<CreateProductCommand, int>
    {
        private readonly IOnlineStoreDbContext _context;

        public CreateProductCommandHandler(IOnlineStoreDbContext context)
        {
            _context = context;
        }
        public async Task<int> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            var entity = new Product
            {
                ProductName = request.NewProduct.Name,
                UnitPrice = request.NewProduct.Price,
            };

            _context.Products.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.ProductId;
        }
    }
}
