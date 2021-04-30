using senai.hroads.webApi.Contexts;
using senai.hroads.webApi.Domains;
using senai.hroads.webApi.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Repositories
{
    public class ClassRepository : IClassRepository
    {
        /// <summary>
        /// Objeto contexto por onde serão chamados os métodos do EF Core
        /// </summary>
        HROADSContext ctx = new HROADSContext();

        public void Atualizar(int id, Class novaClassAtualizada)
        {
            throw new NotImplementedException();
        }

        public Class BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Class novaClass)
        {
            throw new NotImplementedException();
        }

        public void Deletar(int id)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Retorna uma lista de classes
        /// </summary>
        /// <returns>Uma lista de classes</returns>
        public List<Class> Listar()
        {
           // Retornando uma Lista com todas as informações das classes
           return ctx.Classes.ToList();
            
        }
    }
}
