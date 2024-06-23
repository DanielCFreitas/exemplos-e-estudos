using System.Collections.Concurrent;

namespace ILoggerExemplo.CustomLogger
{
    /// <summary>
    /// Classe que representa meu logger customizado e realiza suas configurações de uso
    /// </summary>
    public class MeuLoggerProviderCustomizado : ILoggerProvider
    {
        private readonly MeuLoggerProviderCustomizadoConfiguracao _loggerConfiguracoes;
        private readonly ConcurrentDictionary<string, MeuLoggerCustomizado> _loggers = new ConcurrentDictionary<string, MeuLoggerCustomizado>();

        public MeuLoggerProviderCustomizado(MeuLoggerProviderCustomizadoConfiguracao loggerConfiguracoes)
        {
            _loggerConfiguracoes = loggerConfiguracoes;
        }

        /// <summary>
        /// Cria o registro de log instanciando o meu MeuLoggerCustomizado
        /// </summary>
        /// <param name="categoryName">Categoria do log</param>
        /// <returns>Retorna meu logger customizado</returns>
        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, name => new MeuLoggerCustomizado(name, _loggerConfiguracoes));
        }

        public void Dispose() { }
    }
}
