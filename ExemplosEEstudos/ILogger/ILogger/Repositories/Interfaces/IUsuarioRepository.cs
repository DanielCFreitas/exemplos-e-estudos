using ILoggerExemplo.Model;

namespace ILoggerExemplo.Repositories.Interfaces
{
    /// <summary>
    /// Interface para simular busca de usuarios em um banco de dados
    /// </summary>
    public interface IUsuarioRepository
    {
        /// <summary>
        /// Lista os usuarios 
        /// </summary>
        /// <returns>Retorna lista de usuarios</returns>
        IEnumerable<Usuario> Listar();
    }
}
