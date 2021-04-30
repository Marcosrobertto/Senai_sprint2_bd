using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.hroads.webApi.Interfaces;
using senai.hroads.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Controllers
{
    //Define que o tipo de resposta da API será no formato JSON
    [Produces("application/json")]

    //Define que a rota da requisição será no formato dominió/api/nomeController
    //ex: http://localhost:5000/api/classes

    //Define que é um controlador de API
    [Route("api/[controller]")]
    [ApiController]

    public class ClassController : ControllerBase
    {
        /// <summary>
        /// Objeto _classRepository que irá receber todos os métodos definidos na interface IClasseRepository
        /// </summary>
        private IClassRepository _classRepository { get; set; }

        public ClassController()
        {
            _classRepository = new ClassRepository();
        }


        /// <summary>
        /// Lista todas as classes
        /// </summary>
        /// <returns>Uma lista de classes e um status code 200 - OK </returns>
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(_classRepository.Listar());
        }

    }
}
