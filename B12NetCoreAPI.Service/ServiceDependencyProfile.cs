using B12NetCoreAPI.Service.Interface.Services;
using B12NetCoreAPI.Service.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Service
{
    public class ServiceDependencyProfile { 

        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaService, MahasiswaService>();
            services.AddScoped<IDbService, DbService>();
        }
    }
}
