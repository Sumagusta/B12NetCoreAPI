using B12NetCoreAPI.Model.Entities;
using B12NetCoreAPI.Service.Interface.Services;
using B12NetCoreAPI.Service.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace B12NetCoreAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MahasiswaController : Controller
    {
        private readonly IMahasiswaService mahasiswaService;

        public MahasiswaController(IMahasiswaService mahasiswaService)
        {
            this.mahasiswaService = mahasiswaService;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Mahasiswa model)
        {
            var result = await mahasiswaService.Create(model);
            return Ok(result);
        }

        [HttpGet] // [HttpGet("{id:int}")] -> format ini bisa digunakan jika  ingin inputan berasal dari parameter bukan body
        public async Task<List<Mahasiswa>> GetAll()
        {
            var result = await mahasiswaService.GetAll();
            return result;
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody]Mahasiswa model)
        {
            var result = await mahasiswaService.Update(model);
            return Ok(result);
        }

    }
}
