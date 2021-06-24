﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.sp_medicals.webApi.Interfaces;
using senai.sp_medicals.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Controllers
{
    [Produces("application/json")]
    //Define que a rota de uma requisição, sendo neste formato dominio/api/nomeController
    //Ex: http://localhost:5000/api/tipousuario
    [Route("api/[controller]")]
    [ApiController]
    public class TipoUsuariosController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuariosRepository { get; set; }

        public TipoUsuariosController()
        {
            _tipoUsuariosRepository = new TipoUsuarioRepository();
        }

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_tipoUsuariosRepository.Listar()); 
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

    }
}
