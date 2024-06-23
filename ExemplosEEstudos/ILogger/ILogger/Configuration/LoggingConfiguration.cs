using ILoggerExemplo.CustomLogger;

namespace ILoggerExemplo.Configuration
{
    /// <summary>
    /// Classe que representa a configuracao de Logs da aplicacao
    /// </summary>
    public static class LoggingConfiguration
    {
        /// <summary>
        /// Limpa as configuracoes padrao de logs da aplicacao e adiciona a configracao de logs pelo console,
        /// os providers padrao de logs da aplicacao sao os seguintes:
        /// 
        // - Console
        // - Depurar
        // - EventSource
        // - EventLog
        //
        /// </summary>
        /// <param name="loggingBuilder">LogginBuilder que é responsavel por realizar a configuracao</param>
        public static void AddLoggingConfiguration(this ILoggingBuilder loggingBuilder)
        {
            loggingBuilder.ClearProviders();
            // Logger padrao de console fornecido pela Microsoft
            loggingBuilder.AddConsole();

            // Logger customizado para salvar em arquivo .txt
            loggingBuilder.AddProvider(new MeuLoggerProviderCustomizado(new MeuLoggerProviderCustomizadoConfiguracao()
            {
                LogLevel = LogLevel.Warning
            }));
        }
    }
}
