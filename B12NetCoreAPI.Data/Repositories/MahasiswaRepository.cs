using B12NetCoreAPI.Data.Interface.Repositories;
using B12NetCoreAPI.Model.Entities;
using B12NetCoreAPI.Service.Interface.Services;
using B12NetCoreAPI.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Data.Repositories
{
    public class MahasiswaRepository : IMahasiswaRepository
    {
        private readonly IDbService _dbService;

        public MahasiswaRepository( IDbService dbService)
        {
            _dbService = dbService;
        }

        public async Task<bool> Create(Mahasiswa model)
        {
            await _dbService.ModifyData("INSERT INTO mahasiswa " +
                "(id, nama, alamat, usia, jurusan_id)" +
                "values" +
                "(@Id, @Nama, @Alamat, @Usia, @JurusanId)", model);
            return true;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await _dbService.GetData<Mahasiswa>("select * from mahasiswa", new {});
            return result;

        }
    }
}
