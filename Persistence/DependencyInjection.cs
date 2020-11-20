using Application.Common.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<OnlineStoreDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("OnlineStoreDatabase")));

            services.AddScoped<IOnlineStoreDbContext>(provider => provider.GetService<OnlineStoreDbContext>());

            return services;
        }
    }
}
