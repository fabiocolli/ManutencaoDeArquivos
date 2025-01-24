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

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            var configuration = new ConfigurationBuilder()
                        .SetBasePath(Directory.GetCurrentDirectory())
                        .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                        .Build();

            while (!stoppingToken.IsCancellationRequested)
            {
                _servicoArquivo.ExcluirArquivosAntigos(configuration);

                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Trabalho rodando em: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(1000000, stoppingToken);
            }
        }
    }
}
