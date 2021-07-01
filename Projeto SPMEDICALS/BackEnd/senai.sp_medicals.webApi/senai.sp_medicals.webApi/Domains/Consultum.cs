using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace senai.sp_medicals.webApi.Domains
{
    public partial class Consultum
    {
        public int IdConsulta { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Não é possível agendar uma consulta sem um médico!")]
        public int? IdPaciente { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Não é possível agendar uma consulta sem um paciente!")]
        public int? IdMedico { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "A consulta precisa ter uma situação!")]
        public int? IdSituacao { get; set; }

        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])[/](0[1-9]|1[012])[/](19|20)[0-9][0-9](( )([0-9][0-9][:]){2}[0-9][0-9])?", ErrorMessage = "Por favor, preencha o campo no formato dd/mm/yyyy")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        [DataType(DataType.DateTime, ErrorMessage = "O valor inserido não é uma data válida!")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "A consulta precisa ter um horário!")]
        public DateTime DataConsulta { get; set; }


        [StringLength(maximumLength: 500, ErrorMessage = "A descrição inserida é muito grande!")]
        public string Descricao { get; set; }

        public virtual Medico IdMedicoNavigation { get; set; }
        public virtual Paciente IdPacienteNavigation { get; set; }
        public virtual Situacao IdSituacaoNavigation { get; set; }
    }
}
