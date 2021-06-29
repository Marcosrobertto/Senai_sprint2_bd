using Microsoft.EntityFrameworkCore;
using senai.sp_medicals.webApi.Contexts;
using senai.sp_medicals.webApi.Domains;
using senai.sp_medicals.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.sp_medicals.webApi.Repositories
{
    public class ConsultaRepository : IConsultaRepository
    {

        MedicalsContext ctx = new MedicalsContext();

        public void AprovarRecusar(int id, string status)
        {
            throw new NotImplementedException();
        }

        public void AtualizarPorId(int id, Consultum consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Consultum BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastar(Consultum novaConsulta)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public int IdMedico(int id)
        {
            throw new NotImplementedException();
        }

        public int IdPaciente(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarConsultasMedico(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarConsultasPaciente(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarTudo()
        {
            return ctx.Consulta.Include(c => c.IdMedicoNavigation)
                               .Include(c => c.IdSituacaoNavigation)
                               .Include(c => c.IdPacienteNavigation)
                               .Select(c => new Consultum()
                               {

                               }).ToList();
        }

        public void MudarDescricao(int id, Consultum status)
        {
            throw new NotImplementedException();
        }
    }
}
