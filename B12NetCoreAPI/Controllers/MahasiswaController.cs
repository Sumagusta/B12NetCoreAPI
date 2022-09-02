﻿using B12NetCoreAPI.Model.Entities;
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
    }
}