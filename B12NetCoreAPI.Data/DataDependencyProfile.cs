using B12NetCoreAPI.Data.Interface.Repositories;
using B12NetCoreAPI.Data.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Data
{
    public class DataDependencyProfile
    {
        public static void Register(IConfiguration configuration, IServiceCollection services)
        {
            services.AddScoped<IMahasiswaRepository, MahasiswaRepository>();
        }
    }
}
