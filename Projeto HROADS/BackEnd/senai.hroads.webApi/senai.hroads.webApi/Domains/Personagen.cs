using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Personagen
    {
        public int IdPersonagens { get; set; }
        public int? IdClasse { get; set; }
        public string Nome { get; set; }
        public int CapacidadeMaxVida { get; set; }
        public int CapacidadeMaxMana { get; set; }
        public DateTime DataAtualiz { get; set; }
        public DateTime DateCriacao { get; set; }

        public virtual Class IdClasseNavigation { get; set; }
    }
}
