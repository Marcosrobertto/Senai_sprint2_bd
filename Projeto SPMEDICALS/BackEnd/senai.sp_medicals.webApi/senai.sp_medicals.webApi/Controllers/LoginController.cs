using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using senai.sp_medicals.webApi.Domains;
using senai.sp_medicals.webApi.Interfaces;
using senai.sp_medicals.webApi.Repositories;
using senai.sp_medicals.webApi.ViewModels;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Controllers
{

    [Produces("aplication/json")]
    [Route("api/[controller]")]
    [ApiController]

    //Define que é um controlador de API
    public class LoginController : ControllerBase
    {

        private IUsuarioRepository _usuarioRepository { get; set; }

        public LoginController()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        [HttpPost]

        public IActionResult Login(LoginViewModel login)
        {
            try
            {
                Usuario UsuarioBuscado = _usuarioRepository.Login(login.Email, login.Senha);

                // Caso não encontre usuário com e-mail e senha informados
                if (UsuarioBuscado == null)
                {
                    return NotFound("E-mail ou senha inválida");
                }

                //Caso encontre, prossegue para criação do token

                // Define os dados que serão fornecidos no token - Paylond
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Email, UsuarioBuscado.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, UsuarioBuscado.Idusuario.ToString()),
                    new Claim(ClaimTypes.Role, UsuarioBuscado.IdTipoUsuario.ToString()),
                    new Claim("role", UsuarioBuscado.IdTipoUsuario.ToString())
                };

                //Define a chave de acesso ao token
                var key = new SymmetricSecurityKey(System.Text.Encoding.UTF8.GetBytes("medicals-chave-Autenticacao"));

                // Define as credenciais do token - Header
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                //Define a composição do token
                var token = new JwtSecurityToken(
                    issuer: "medicals.webApi",
                    audience: "medical.webApi",
                    claims: claims,
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: creds
                    );

                //Retorna Ok com token
                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token)
                });


            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }
        }
    }
}
