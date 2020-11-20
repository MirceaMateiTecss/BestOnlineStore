using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class OnlineStoreDbContextFactory : DesignTimeDbContextFactoryBase<OnlineStoreDbContext>
    {
        protected override OnlineStoreDbContext CreateNewInstance(DbContextOptions<OnlineStoreDbContext> options)
        {
            return new OnlineStoreDbContext(options);
        }
    }
}
