using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure
{
    public static class DependecyInjection
    {
        public static IServiceCollection ImplementPersistence(this
            IServiceCollection services , IConfiguration configuration)
        {
            services.AddDbContext<MovieRentalDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(MovieRentalDbContext).Assembly.FullName)), ServiceLifetime.Transient);

            services.AddScoped<IMovieRentalDbContext>(provider =>
            provider.GetService<MovieRentalDbContext>());

            return services;
        }
    }
}
