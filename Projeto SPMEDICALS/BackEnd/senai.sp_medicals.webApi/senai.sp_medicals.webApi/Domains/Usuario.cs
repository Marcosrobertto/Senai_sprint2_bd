using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.sp_medicals.webApi.Domains
{
    public partial class Usuario
    {
        public Usuario()
        {
            Medicos = new HashSet<Medico>();
            Pacientes = new HashSet<Paciente>();
        }

        //Define que o campo é obrigatório
        [Required(ErrorMessage = "Informe o nome do usuário")]
        public int Idusuario { get; set; }

        [Required(ErrorMessage = "Informe o Id do Tipo Usuario")]
        public int? IdTipoUsuario { get; set; }

        [Required(ErrorMessage = "Informe a E-mail")]
        public string Email { get; set; }

        [StringLength(100, MinimumLength = 5, ErrorMessage = "A senha deve conter no mínimo 5 caracteres")]
        public string Senha { get; set; }

        public virtual TipoUsuario IdTipoUsuarioNavigation { get; set; }
        public virtual ICollection<Medico> Medicos { get; set; }
        public virtual ICollection<Paciente> Pacientes { get; set; }
    }
}
