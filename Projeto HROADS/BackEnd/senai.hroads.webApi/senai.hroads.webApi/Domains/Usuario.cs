using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Usuario
    {
        public int IdUsurios { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public int? IdTiposUsuarios { get; set; }

        public virtual TiposUsuario IdTiposUsuariosNavigation { get; set; }
    }
}
