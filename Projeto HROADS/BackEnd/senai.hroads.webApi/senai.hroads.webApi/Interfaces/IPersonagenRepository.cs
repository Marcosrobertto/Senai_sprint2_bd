using senai.hroads.webApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.hroads.webApi.Interfaces
{
    interface IPersonagenRepository

    {
        /// <summary>
        /// Retorna uma lista de personagens
        /// </summary>
        /// <returns>Uma lista de personagens</returns>
        List<Personagen> Listar();

        /// <summary>
        /// Busca um personagem pelo seu id
        /// </summary>
        /// <param name="id">Id do personagem que será buscada</param>
        /// <returns>Um personagem buscada</returns>
        Personagen BuscarPorId(int id);

        /// <summary>
        /// Cadastra uma nova personagem
        /// </summary>
        /// <param name="novoPersonagem">Objeto novoPersonagem que será cadastrada</param>
        void Cadastrar(Personagen novoPersonagem);

        /// <summary>
        /// Atualiza uma personagem existente
        /// </summary>
        /// <param name="id">ID da personagem que será atualizada</param>
        /// <param name="personagemAtualizado">Objeto personagemAtualizada com as novas informações</param>
        void Atualizar(int id, Personagen personagemAtualizado);

        /// <summary>
        /// Deleta um personagem existente
        /// </summary>
        /// <param name="id">ID do personagem que será deletada</param>
        void Deletar(int id);

        /// <summary>
        /// Lista todos os tipos de personagens com suas respectivas personagens
        /// </summary>
        /// <returns>Uma lista de tipos personagens com suas classes</returns>
        List<Personagen> ListarClasse();


    }
}
