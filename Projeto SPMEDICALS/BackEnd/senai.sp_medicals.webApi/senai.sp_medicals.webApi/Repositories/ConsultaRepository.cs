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
            Consultum consultaBuscada = ctx.Consulta.Find(id);

            if (consultaAtualizada.IdMedico != null)
            {
                consultaAtualizada.IdMedico = consultaAtualizada.IdMedico;
            }
            if (consultaAtualizada.IdPaciente != null)
            {
                consultaAtualizada.IdPaciente = consultaAtualizada.IdPaciente;
            }
            if (consultaAtualizada.IdSituacao != null)
            {
                consultaAtualizada.IdSituacao = consultaAtualizada.IdSituacao;
            }
            if (consultaAtualizada.Descricao != null)
            {
                consultaBuscada.Descricao = consultaAtualizada.Descricao;
            }
            if (consultaAtualizada.DataConsulta != Convert.ToDateTime("0001-01-01"))
            {
                consultaBuscada.DataConsulta = consultaAtualizada.DataConsulta;
            }

            ctx.Update(consultaBuscada);

            ctx.SaveChanges();
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
            Consultum consultaBuscada = ctx.Consulta.FirstOrDefault(u => u.IdConsulta == id);

            ctx.Consulta.Remove(consultaBuscada);

            ctx.SaveChanges();

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

        public List<Consultum> ListarMinhas(int idUsuario)
        {
            Paciente pacienteBuscado = ctx.Pacientes.FirstOrDefault(c => c.IdUsuario == idUsuario);

            Medico medicoBuscado = ctx.Medicos.FirstOrDefault(c => c.IdUsuario == idUsuario);

            if (pacienteBuscado != null)
            {
                return ctx.Consulta.Where(c => c.IdPaciente == pacienteBuscado.IdPaciente)
                    .Include(c => c.IdPacienteNavigation)
                    .Include(c => c.IdMedicoNavigation)
                    .Include(c => c.IdSituacaoNavigation)
                    .Include(c => c.IdMedicoNavigation.IdEspecialidadeNavigation)
                    .Select(c => new Consultum 
                    { 
                        IdConsulta = c.IdConsulta,
                        IdMedicoNavigation = c.IdMedicoNavigation,
                        IdPacienteNavigation = c.IdPacienteNavigation,
                        IdSituacaoNavigation = c.IdSituacaoNavigation,
                        Descricao = c.Descricao,
                        DataConsulta = c.DataConsulta
                    })
                    .ToList();

            }

            if (medicoBuscado != null) 
            {
                return ctx.Consulta.Include(c => c.IdMedicoNavigation).Where(c => c.IdMedico == medicoBuscado.IdMedico)
                    .Include(c => c.IdPacienteNavigation)
                    .Include(c => c.IdMedicoNavigation)
                    .Include(c => c.IdSituacaoNavigation)
                    .Include(c => c.IdMedicoNavigation.IdEspecialidadeNavigation)
                    .Select(c => new Consultum
                    {
                        IdConsulta = c.IdConsulta,
                        IdMedicoNavigation = c.IdMedicoNavigation,
                        IdPacienteNavigation = c.IdPacienteNavigation,
                        IdSituacaoNavigation = c.IdSituacaoNavigation,
                        Descricao = c.Descricao,
                        DataConsulta = c.DataConsulta
                    })
                    .ToList();
            }

            return null;

        }


        public void MudarDescricao(int id, Consultum status)
        {
            throw new NotImplementedException();
        }
    }
}
