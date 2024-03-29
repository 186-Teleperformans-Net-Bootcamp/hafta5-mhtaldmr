﻿using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TP.Net.Hw.Application.Mapping;

namespace TP.Net.Hw.Application.DependencyContainer
{
    public static class DependencyContainer
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            //Mapping
            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
