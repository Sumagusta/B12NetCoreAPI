using B12NetCoreAPI.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Data.Interface.Repositories
{
    public interface IMahasiswaRepository
    {
        public Task<bool> Create(Mahasiswa model);
        public Task<List<Mahasiswa>> GetAll();
        public Task<Mahasiswa> Update(Mahasiswa model);
        
    }
}
