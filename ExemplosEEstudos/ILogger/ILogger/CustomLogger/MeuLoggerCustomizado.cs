
namespace ILoggerExemplo.CustomLogger
{
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

        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception? exception, Func<TState, Exception?, string> formatter)
        {
            string mensagem = string.Format("{0}: {1} - {2}", logLevel.ToString(), eventId, formatter(state, exception));
            EscreverNoArquivo(mensagem);
        }

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
