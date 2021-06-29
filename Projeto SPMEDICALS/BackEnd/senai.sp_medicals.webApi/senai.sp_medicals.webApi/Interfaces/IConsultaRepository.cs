using senai.sp_medicals.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Interfaces
{
    interface IConsultaRepository
    {

        int IdPaciente(int id);

        int IdMedico(int id);

        Consultum BuscarPorId(int id);

        void MudarDescricao(int id, Consultum status);

        void AprovarRecusar(int id, string status);

        void Cadastar(Consultum novaConsulta);

        void AtualizarPorId(int id, Consultum consultaAtualizada);

        void Deletar(int id);

        List<Consultum> ListarTudo();

        List<Consultum> ListarConsultasPaciente(int id);

        List<Consultum> ListarConsultasMedico(int id);

    }
}
