using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo ClasseRepository
    /// </summary>
    interface IClassesHabilidadeRepository


    {
        /// <summary>
        /// Retorna uma lista de classes
        /// </summary>
        /// <returns>Uma lista de classes</returns>
        List<ClassesHabilidade> Listar();

        /// <summary>
        /// Busca uma classe pelo seu id
        /// </summary>
        /// <param name="id">Id da classe que será buscada</param>
        /// <returns>Uma classe buscada</returns>
        TiposHabilidade BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova classe
        /// </summary>
        /// <param name="novoTiposHabilidade">Objeto novaClasse que será cadastrada</param>
        void Cadastrar(TiposHabilidade novoTiposHabilidade);

        /// <summary>
        /// Atualiza uma classe existente
        /// </summary>
        /// <param name="id">ID da classe que será atualizada</param>
        /// <param name="tiposHabilidadeAtualizada">Objeto classeAtualizada com as novas informações</param>
        void Atualizar(int id, TiposHabilidade tiposHabilidadeAtualizada);

        /// <summary>
        /// Deleta uma classe existente
        /// </summary>
        /// <param name="id">ID da classe que será deletada</param>
        void Deletar(int id);
    }
}
