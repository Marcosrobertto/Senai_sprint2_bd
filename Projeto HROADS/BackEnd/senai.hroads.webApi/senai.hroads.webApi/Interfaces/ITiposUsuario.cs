using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface ITiposUsuario
    {
        /// <summary>
        /// Retorna uma lista de tipos de usuários
        /// </summary>
        /// <returns>Uma lista de tipos de usuários</returns>
        List<TiposUsuario> Listar();

        /// <summary>
        /// Busca um tipo de usuário pelo seu id
        /// </summary>
        /// <param name="id">Id do tipo de usuário que será buscado</param>
        /// <returns>Um tipo de usuário buscada</returns>
        TiposUsuario BuscarPorId(int id);

        /// <summary>
        /// Cadastra um tipo de usuário 
        /// </summary>
        /// <param name="novoTiposUsuario">Objeto novoTipoUsuario que será cadastrado</param>
        void Cadastrar(TiposUsuario novoTiposUsuario);

        /// <summary>
        /// Atualiza um tipo de usuário existente
        /// </summary>
        /// <param name="id">ID dao tipo usuário que será atualizada</param>
        /// <param name="tiposUsuarioAtualizado">Objeto tipoUsuarioAtualizado com as novas informações</param>
        void Atualizar(int id, TiposUsuario tiposUsuarioAtualizado);

        /// <summary>
        /// Deleta um tipo de usuário existente
        /// </summary>
        /// <param name="id">ID do tipo usuário que será deletado</param>
        void Deletar(int id);



    }
}
