using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITiposHabilidadeRepository
    {
        /// <summary>
        /// Retorna uma lista de tipos de habilidades
        /// </summary>
        /// <returns>Uma lista de tipos de habilidades</returns>
        List<TiposHabilidade> Listar();

        /// <summary>
        /// Busca um tipo de habilidade pelo seu id
        /// </summary>
        /// <param name="id">Id do tipo de habilidade que será buscada</param>
        /// <returns>Um tipo de habilidade buscada</returns>
        TiposHabilidade BuscarPorId(int id);

        /// <summary>
        /// Cadastra um novo tipo de  habilidade
        /// </summary>
        /// <param name="novoTipoHabilidade">Objeto novaTipoHabilidade que será cadastrada</param>
        void Cadastrar(TiposHabilidade novoTipoHabilidade);

        /// <summary>
        /// Atualiza um tipo de habilidade existente
        /// </summary>
        /// <param name="id">ID do tipo de habilidade que será atualizada</param>
        /// <param name="tiposHabilidadeAtualizada">Objeto tipoHabilidadeAtualizada com as novas informações</param>
        void Atualizar(int id, TiposHabilidade tiposHabilidadeAtualizada);

        /// <summary>
        /// Deleta um tipo de habilidade existente
        /// </summary>
        /// <param name="id">ID do tipo de habilidade que será deletada</param>
        void Deletar(int id);
    }
}
