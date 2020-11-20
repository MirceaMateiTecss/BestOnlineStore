using System.Collections.Generic;
using Application.Common.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using Domain.Entites;
using Microsoft.EntityFrameworkCore.Internal;

namespace Application.System.Commands.SeedSampleData
{
    public class SampleDataSeeder
    {
        private readonly IOnlineStoreDbContext _context;

        private readonly Dictionary<int, Product> Products = new Dictionary<int, Product>();

        public SampleDataSeeder(IOnlineStoreDbContext context)
        {
            _context = context;
        }

        public async Task SeedAllAsync(CancellationToken cancellationToken)
        {
            await SeedProductsAsync(cancellationToken);
        }

        private async Task SeedProductsAsync(CancellationToken cancellationToken)
        {
            if (_context.Products.Any())
            {
                return;
            }

            Products.Add(1, new Product { ProductName = "Product1", UnitPrice = 18.00m});
            Products.Add(2, new Product { ProductName = "Product2", UnitPrice = 19.00m, });
            Products.Add(3, new Product { ProductName = "Product3",  UnitPrice = 20.00m});
            Products.Add(4, new Product { ProductName = "Product4", UnitPrice = 21.00m });
            Products.Add(5, new Product { ProductName = "Product5", UnitPrice = 22.00m });
            Products.Add(6, new Product { ProductName = "Product6", UnitPrice = 23.00m, });
            Products.Add(7, new Product { ProductName = "Product7", UnitPrice = 24.00m });
            Products.Add(8, new Product { ProductName = "Product8", UnitPrice = 25.00m });
            Products.Add(9, new Product { ProductName = "Product9", UnitPrice = 26.00m });
            Products.Add(10, new Product { ProductName = "Product10", UnitPrice = 27.00m });

            foreach (var product in Products.Values)
            {
                _context.Products.Add(product);
            }

            await _context.SaveChangesAsync(cancellationToken);
        }
    }
}
