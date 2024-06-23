using ILoggerExemplo.Model;
using ILoggerExemplo.Repositories.Interfaces;

namespace ILoggerExemplo.Repositories
{
    public class UsuarioRepository : IUsuarioRepository
    {
        public IEnumerable<Usuario> Listar()
        {
            return new List<Usuario>()
            {
                new Usuario("Daniel", "daniel@gmail.com", "123"),
                new Usuario("Fernando", "fernando@gmail.com", "123"),
                new Usuario("Rafael", "rafael@gmail.com", "123"),
                new Usuario("Rogério", "rogerio@gmail.com", "123"),
                new Usuario("Rodolfo", "rodolfo@gmail.com", "123")
            };
        }
    }
}
