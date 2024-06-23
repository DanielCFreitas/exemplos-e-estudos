namespace ILoggerExemplo.CustomLogger
{
    /// <summary>
    /// Classe responsável por configurar o meu log provider customizado
    /// </summary>
    public class MeuLoggerProviderCustomizadoConfiguracao
    {
        /// <summary>
        /// Define o nivel de log que meu provider customizado deve exibir as informacoes
        /// </summary>
        public LogLevel LogLevel { get; set; } = LogLevel.Warning;

        /// <summary>
        /// Indica qual e o Id do evento
        /// </summary>
        public int EventId { get; set; } = 0;
    }
}
