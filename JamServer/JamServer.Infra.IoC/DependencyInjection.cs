using JamServer.Application.Interfaces;
using JamServer.Application.Mappings;
using JamServer.Application.Services;
using JamServer.Domain.Interfaces;
using JamServer.Infra.Data.Context;
using JamServer.Infra.Data.Repos;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JamServer.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                        b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IClothesRepository, ClothesRepository>();
            services.AddScoped<IAthleteRepository, AthleteRepository>();

            services.AddScoped<IClothesService, ClothesService>();
            services.AddScoped<IAthleteService, AthleteService>();

            services.AddAutoMapper(typeof(DomainToDTOMappingProfile));
            services.AddMediatR(AppDomain.CurrentDomain.Load("JamServer.Application"));

            return services;
        }
    }
}
