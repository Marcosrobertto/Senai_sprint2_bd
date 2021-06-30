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

        public void AtualizarPorId(int id, Consultum consultaAtualizada)
        {
            throw new NotImplementedException();
        }

        public Consultum BuscarPorId(int id)
        {
            return ctx.Consulta.FirstOrDefault(u => u.IdConsulta == id);
        }

        public void Cadastrar(Consultum novaConsulta)
        {
            ctx.Consulta.Add(novaConsulta);

            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Consultum> ListarConsultasMedico()
        {
            return ctx.Consulta
                              .Include(c => c.IdMedicoNavigation)
                              .Include(c => c.IdSituacaoNavigation)
                              .Select(c => new Consultum()
                              {
                                  IdMedicoNavigation = new Medico()
                                  {
                                      IdMedico = c.IdMedicoNavigation.IdMedico,
                                      NomeMedico = c.IdMedicoNavigation.NomeMedico,
                                      IdEspecialidade = c.IdMedicoNavigation.IdEspecialidade,
                                      IdClinica = c.IdMedicoNavigation.IdClinica,

                                      IdEspecialidadeNavigation = new Especialidade()
                                      {
                                          IdEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.IdEspecialidade,
                                          Especialidade1 = c.IdMedicoNavigation.IdEspecialidadeNavigation.Especialidade1
                                      }
                                  }
                              })
                              .ToList();
        }

        public List<Consultum> ListarConsultasPaciente()
        {
            return ctx.Consulta

                               .Include(c => c.IdPacienteNavigation)
                               .Include(c => c.IdSituacaoNavigation)
                               .Select(c => new Consultum()
                               {
                                   IdConsulta = c.IdConsulta,
                                   Descricao = c.Descricao,
                                   DataConsulta = c.DataConsulta,

                                   IdPacienteNavigation = new Paciente()
                                   {
                                       IdPaciente = c.IdPacienteNavigation.IdPaciente,
                                       NomePaciente = c.IdPacienteNavigation.NomePaciente,
                                       DataNascimento = c.IdPacienteNavigation.DataNascimento,
                                       Rg = c.IdPacienteNavigation.Rg,
                                       Cpf = c.IdPacienteNavigation.Cpf,
                                       Endereco = c.IdPacienteNavigation.Endereco
                                   },

                                   IdSituacaoNavigation = new Situacao()
                                   {
                                       IdSituacao = c.IdSituacaoNavigation.IdSituacao,
                                       Situacao1 = c.IdSituacaoNavigation.Situacao1

                                   }


                               })

                               .ToList();

        }

        public List<Consultum> ListarTudo()
        {
            return ctx.Consulta
                
                               .Include(c => c.IdPacienteNavigation)
                               .Include(c => c.IdMedicoNavigation)
                               .Include(c => c.IdSituacaoNavigation)
                               .Select(c => new Consultum()
                               {
                                   IdConsulta = c.IdConsulta,
                                   Descricao = c.Descricao,
                                   DataConsulta = c.DataConsulta,

                                   IdMedicoNavigation = new Medico()
                                   {
                                       IdMedico = c.IdMedicoNavigation.IdMedico,
                                       NomeMedico = c.IdMedicoNavigation.NomeMedico,
                                       IdEspecialidade = c.IdMedicoNavigation.IdEspecialidade,
                                       IdClinica = c.IdMedicoNavigation.IdClinica,

                                       IdEspecialidadeNavigation = new Especialidade()
                                       {
                                           IdEspecialidade = c.IdMedicoNavigation.IdEspecialidadeNavigation.IdEspecialidade,
                                           Especialidade1 = c.IdMedicoNavigation.IdEspecialidadeNavigation.Especialidade1
                                       }
                                   },

                                   

                                   IdPacienteNavigation = new Paciente()
                                   {
                                       IdPaciente = c.IdPacienteNavigation.IdPaciente,
                                       NomePaciente = c.IdPacienteNavigation.NomePaciente,
                                       DataNascimento = c.IdPacienteNavigation.DataNascimento,
                                       Rg = c.IdPacienteNavigation.Rg,
                                       Cpf = c.IdPacienteNavigation.Cpf,
                                       Endereco = c.IdPacienteNavigation.Endereco
                                   },

                                   IdSituacaoNavigation = new Situacao()
                                   {
                                       IdSituacao = c.IdSituacaoNavigation.IdSituacao,
                                       Situacao1 = c.IdSituacaoNavigation.Situacao1

                                   }


                               })

                               .ToList();
        }

        public void MudarDescricao(int id, Consultum status)
        {
            throw new NotImplementedException();
        }
    }
}
