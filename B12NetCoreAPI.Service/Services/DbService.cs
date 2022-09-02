using B12NetCoreAPI.Service.Interface.Services;
using Dapper;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Service.Services
{
    public class DbService : IDbService
    {
        private readonly IDbConnection _db;

        public DbService(IConfiguration configuration)
        {
            _db = new MySqlConnection(configuration.GetConnectionString("ConnectKampus12"));
        }

        public async Task<List<T>> GetData<T>(string command, object param)
        {           
            List<T> result = (await _db.QueryAsync<T>(command, param)).ToList();
            return result;
        }

        public async Task<int> ModifyData(string command, object param)
        {
            var result = await _db.ExecuteAsync(command, param);
            return result;
        }



    }
}
