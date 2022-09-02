using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Model.Entities
{
    public class Mahasiswa
    {
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public int Usia { get; set; }
        public int JurusanId { get; set; }

    }
}
