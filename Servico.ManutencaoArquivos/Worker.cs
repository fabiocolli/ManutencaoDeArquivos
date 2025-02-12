using Aplicacao.ManutencaoDeArquivo.Interfaces;

namespace Servico.ManutencaoArquivos
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly IServicoArquivo _servicoArquivo;

        public Worker(ILogger<Worker> logger, IServicoArquivo servicoArquivo)
        {
            _logger = logger;
            _servicoArquivo = servicoArquivo;
        }

        protected override async Task ExecuteAsync(CancellationToken tokenDeCancelamento)
        {
            var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .Build();

            while (!tokenDeCancelamento.IsCancellationRequested)
            {
                _servicoArquivo.ExcluirArquivosAntigos(configuration);

                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Trabalho rodando em: {time}", DateTimeOffset.Now);
                }

                var horas = 3;

                var mileSegundos = horas * 60 * 60 * 1000;

                await Task.Delay(mileSegundos, tokenDeCancelamento);
            }
        }
    }
}
