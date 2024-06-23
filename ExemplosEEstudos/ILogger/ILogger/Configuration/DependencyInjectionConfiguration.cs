using ILoggerExemplo.Repositories;
using ILoggerExemplo.Repositories.Interfaces;

namespace ILoggerExemplo.Configuration
{
    /// <summary>
    /// Classe responsavel por injetar as dependencias da aplicacao
    /// </summary>
    public static class DependencyInjectionConfiguration
    {
        /// <summary>
        /// Adiciona as dependencias da aplicacao
        /// </summary>
        /// <param name="service">ServiceCollection que faz a injecao das dependencias</param>
        public static void AddDependencyInjectionConfiguration(this IServiceCollection service)
        {
            service.AddScoped<IUsuarioRepository, UsuarioRepository>();
        }
    }
}
