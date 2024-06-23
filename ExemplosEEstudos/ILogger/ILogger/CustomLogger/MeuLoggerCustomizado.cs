
namespace ILoggerExemplo.CustomLogger
{
    /// <summary>
    /// Classe do meu logger customizado para salvar os logs em um arquivo .txt
    /// </summary>
    public class MeuLoggerCustomizado : ILogger
    {
        private readonly string _nomeDoLogger;
        private readonly MeuLoggerProviderCustomizadoConfiguracao _loggerConfiguracoes;

        public MeuLoggerCustomizado(string nomeDoLogger, MeuLoggerProviderCustomizadoConfiguracao loggerConfiguracoes)
        {
            _nomeDoLogger = nomeDoLogger;
            _loggerConfiguracoes = loggerConfiguracoes;
        }

        public IDisposable? BeginScope<TState>(TState state) where TState : notnull => null;

        public bool IsEnabled(LogLevel logLevel) => true;

        /// <summary>
        /// Método chamado quando faz um novo log
        /// </summary>
        /// <typeparam name="TState"></typeparam>
        /// <param name="logLevel"></param>
        /// <param name="eventId"></param>
        /// <param name="state"></param>
        /// <param name="exception"></param>
        /// <param name="formatter"></param>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string mensagem = string.Format("{0}: {1} - {2}", logLevel.ToString(), eventId, formatter(state, exception));
            EscreverNoArquivo(mensagem);
        }

        /// <summary>
        /// Escreve no arquivo txt a mensagem de log
        /// </summary>
        /// <param name="mensagem">Mensagem que deve ser registrada no .txt</param>
        private void EscreverNoArquivo(string mensagem)
        {
            var diretorioAtual = Directory.GetCurrentDirectory();
            var nomeArquivo = $"{DateTime.Now:dd-MM-yyyy}.txt";
            var diretorioCompleto = Path.Combine(diretorioAtual, nomeArquivo);

            using StreamWriter streamWritter = new StreamWriter(diretorioCompleto, true);
            streamWritter.WriteLine(mensagem);
            streamWritter.Close();
        }
    }
}
