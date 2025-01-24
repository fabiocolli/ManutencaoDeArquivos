using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Dominio.ManutencaoArquivos.Interface;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Aplicacao.ManutencaoDeArquivo.Servico
{
    public class ServicoArquivo : IServicoArquivo
    {
        private readonly IRegraExclusaoDeArquivo _regraExclusaoDeArquivo;
        private readonly IServicoDeConfiguracao _configuracaoService;
        private readonly IServicoArquivoDeSistema _servicoArquivoDeSistema;
        private readonly ILogger<ServicoArquivo> _logger;

        public ServicoArquivo(IRegraExclusaoDeArquivo regraExclusaoDeArquivo, IServicoDeConfiguracao configuracaoService, IServicoArquivoDeSistema servicoArquivoDeSistema, ILogger<ServicoArquivo> logger)
        {
            _regraExclusaoDeArquivo = regraExclusaoDeArquivo;
            _configuracaoService = configuracaoService;
            _servicoArquivoDeSistema = servicoArquivoDeSistema;
            _logger = logger;
        }

        public void ExcluirArquivosAntigos(IConfigurationRoot configuracao)
        {
            var descLog = "Iniciando a exclusão de arquivos antigos.";
            var quantidadeDeArquivosExcluidos = 0;

            var configuracoesDoAppSettings = _configuracaoService.ObterConfiguracoes(configuracao);
            descLog += $"Configurações obtidas: {configuracoesDoAppSettings}";

            var arquivos = _servicoArquivoDeSistema.ObterArquivosDasPastas(configuracoesDoAppSettings);
            quantidadeDeArquivosExcluidos += arquivos.Count();
            descLog += $"Arquivos obtidos :{quantidadeDeArquivosExcluidos}";

            foreach (var arquivo in arquivos)
            {
                _servicoArquivoDeSistema.ExcluirArquivo(arquivo);
            }

            _logger.LogInformation(descLog);
        }
    }
}
