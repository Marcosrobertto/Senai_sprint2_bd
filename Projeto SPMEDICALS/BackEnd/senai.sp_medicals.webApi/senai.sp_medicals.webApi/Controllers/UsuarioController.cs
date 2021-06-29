using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.sp_medicals.webApi.Domains;
using senai.sp_medicals.webApi.Interfaces;
using senai.sp_medicals.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public UsuarioController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpGet]

        public IActionResult Get()
        {
            try
            {
                return Ok(_usuarioRepository.Listar());
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
                return Ok(_usuarioRepository.BuscarPorId(id));
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPost]

        public IActionResult Post(Usuario novoUsuario)
        {

            try
            {
                _usuarioRepository.Cadastrar(novoUsuario);

                return StatusCode(201);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpPut("{id}")]

        public IActionResult Put(int id, Usuario usuarioAtualizado)
        {
            try
            {
                _usuarioRepository.Atualizar(id, usuarioAtualizado);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }

        [HttpDelete("{id}")]

        public IActionResult Delete(int id)
        {
            try
            {
                _usuarioRepository.Deletar(id);

                return StatusCode(204);
            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }


    }
}
