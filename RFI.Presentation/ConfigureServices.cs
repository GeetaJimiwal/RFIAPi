using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using RFI.FRI.Application.Common;
using RFI.FRI.Application.Interfaces;
using RFI.FRI.Application.Services;
using RFI.FRI.Domain.Repositories;
using RFI.FRI.Infrastructure.Repositories;

namespace RFI.FRI.Presentation
{
    public static class ConfigureServices
    {
        /*public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<FRIdbContext>(options =>
            options.UseNpgsql("Host=localhost;Database=FRIDATA;Username=postgres;Password=password"));


            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

           *//* services.AddScoped<IApplicationDbContext, FRIDbContext>();*//*

            return services;
        }*/

        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
         

            if (configuration.GetValue<bool>("UseInMemoryDatabase"))
            {
                services.AddDbContext<FRIdbContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                     builder => builder.MigrationsAssembly(typeof(FRIdbContext).Assembly.FullName)));
                /*  options.UseInMemoryDatabase("FRIDATA"));*/
            }
            else
            {

                services.AddDbContext<FRIdbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection"),
                        builder => builder.MigrationsAssembly(typeof(FRIdbContext).Assembly.FullName)));
            }
            return services;

        }
    }

}
