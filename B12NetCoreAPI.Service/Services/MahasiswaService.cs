using B12NetCoreAPI.Data.Interface.Repositories;
using B12NetCoreAPI.Model.Entities;
using B12NetCoreAPI.Service.Interface.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Service.Services
{
    public class MahasiswaService : IMahasiswaService
    {
        private readonly IMahasiswaRepository mahasiswaRepository;

        public MahasiswaService(IMahasiswaRepository mahasiswaRepository)
        {
            this.mahasiswaRepository = mahasiswaRepository;
        }

        public async Task<bool> Create(Mahasiswa mahasiswa)
        {
            var result = await mahasiswaRepository.Create(mahasiswa);
            return result;
        }

        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaRepository.GetAll();
            return result;
        }
    }
}
