using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Dominio.ManutencaoArquivos.Interface;
using Infraestrutura.ManutencaoArquivos.Interfaces;

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

        public void ExcluirArquivosAntigos()
        {
            throw new NotImplementedException();
        }
    }
}
