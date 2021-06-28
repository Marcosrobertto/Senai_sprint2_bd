using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using senai.sp_medicals.webApi.Interfaces;
using senai.sp_medicals.webApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    //Define que é um controlador de API
    public class LoginController : ControllerBase
    {

        private ITipoUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new TipoUsuarioRepository();
        }



    }
}
