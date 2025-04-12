using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TestN5.Infrastructure.Persistence;

namespace TestN5.Infrastructure
{
    public static class DependencyInyection
    {
        public static IServiceCollection AddInfraestructuraServices(this IServiceCollection services,
                IConfiguration configuration)
        {
            services.AddDbContext<TestDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("Database")));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();

            // generic Base
            //services.AddScoped(typeof(IAsyncRepository<>), typeof(RepositoryBase<>));

            return services;
        }
    }
}
