using System.Collections.Concurrent;

namespace ILoggerExemplo.CustomLogger
{
    public class MeuLoggerProviderCustomizado : ILoggerProvider
    {
        private readonly MeuLoggerProviderCustomizadoConfiguracao _loggerConfiguracoes;
        private readonly ConcurrentDictionary<string, MeuLoggerCustomizado> _loggers = new ConcurrentDictionary<string, MeuLoggerCustomizado>();

        public MeuLoggerProviderCustomizado(MeuLoggerProviderCustomizadoConfiguracao loggerConfiguracoes)
        {
            _loggerConfiguracoes = loggerConfiguracoes;
        }

        public ILogger CreateLogger(string categoryName)
        {
            return _loggers.GetOrAdd(categoryName, name => new MeuLoggerCustomizado(name, _loggerConfiguracoes));
        }

        public void Dispose() { }
    }
}
