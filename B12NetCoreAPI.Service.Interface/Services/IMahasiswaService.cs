using B12NetCoreAPI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Service.Interface.Services
{
    public interface IMahasiswaService
    {
        public Task<bool> Create(Mahasiswa mahasiswa);
        public Task<List<Mahasiswa>> GetAll();
    }
}
