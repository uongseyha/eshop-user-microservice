using Microsoft.Extensions.DependencyInjection;
using eShop.Core.RepositoryContracts;
using eShop.Infrastructure.Repositories;
using eCommerce.Infrastructure.DbContext;

namespace eShop.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IUsersRepository, UsersRepository>();
            services.AddTransient<DapperDbContext>();
            return services;
        }
    }
}
