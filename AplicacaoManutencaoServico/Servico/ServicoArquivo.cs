using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Dominio.ManutencaoArquivos.Interface;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Aplicacao.ManutencaoDeArquivo.Servico
{
    public class ServicoArquivo : IServicoArquivo
    {
        private readonly IRegraExclusaoDeArquivo _regraExclusaoDeArquivo;
        private readonly IServicoDeConfiguracao _configuracaoService;
        private readonly IServicoArquivoDeSistema _servicoArquivoDeSistema;

        public ServicoArquivo(IRegraExclusaoDeArquivo regraExclusaoDeArquivo, IServicoDeConfiguracao configuracaoService, IServicoArquivoDeSistema servicoArquivoDeSistema)
        {
            _regraExclusaoDeArquivo = regraExclusaoDeArquivo;
            _configuracaoService = configuracaoService;
            _servicoArquivoDeSistema = servicoArquivoDeSistema;
        }

        public void ExcluirArquivosAntigos(IConfigurationRoot configuracao)
        {
            var configuracoesDoAppSettings = _configuracaoService.ObterConfiguracoes(configuracao);

            var arquivos = _servicoArquivoDeSistema.ObterArquivosDasPastas(configuracoesDoAppSettings);

            foreach (var arquivo in arquivos)
            {
                _servicoArquivoDeSistema.ExcluirArquivo(arquivo);
            }
        }
    }
}
