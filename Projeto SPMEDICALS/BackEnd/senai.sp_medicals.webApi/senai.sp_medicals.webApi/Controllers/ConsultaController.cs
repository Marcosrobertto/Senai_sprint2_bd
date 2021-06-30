using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.sp_medicals.webApi.Domains;
using senai.sp_medicals.webApi.Interfaces;
using senai.sp_medicals.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Controllers
{

    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class ConsultaController : ControllerBase
    {

        private IConsultaRepository _consultaRepository { get; set; }

        public ConsultaController()
        {
            _consultaRepository = new ConsultaRepository();
        }

        [HttpGet("lista")]
        public IActionResult GetConsultas()
        {
            try
            {
                return Ok(_consultaRepository.ListarTudo());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("Consulta-paciente")]
        public IActionResult GetPaciente()
        {
            try
            {
                return Ok(_consultaRepository.ListarConsultasPaciente());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("Consulta-medico")]
        public IActionResult GetMedico()
        {
            try
            {
                return Ok(_consultaRepository.ListarConsultasMedico());
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            try
            {
                return Ok(_consultaRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }

        [HttpPost]
        public IActionResult Post(Consultum novaConsulta)
        {
            try
            {
                _consultaRepository.Cadastrar(novaConsulta);

                return StatusCode(201);
            }
            catch (Exception ex)
            {
                return BadRequest(ex);
            }
        }



    }
}
