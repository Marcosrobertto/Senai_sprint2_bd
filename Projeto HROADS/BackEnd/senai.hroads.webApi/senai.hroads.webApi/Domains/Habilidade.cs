using System;
using System.Collections.Generic;

#nullable disable

namespace senai.hroads.webApi.Domains
{
    public partial class Habilidade
    {
        public int IdHabilidade { get; set; }
        public int? IdTipo { get; set; }
        public string Nome { get; set; }

        public virtual TiposHabilidade IdTipoNavigation { get; set; }
    }
}
