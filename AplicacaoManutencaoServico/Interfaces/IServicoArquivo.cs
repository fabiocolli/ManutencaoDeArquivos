using Microsoft.Extensions.Configuration;

namespace Aplicacao.ManutencaoDeArquivo.Interfaces
{
    public interface IServicoArquivo
    {
        void ExcluirArquivosAntigos(IConfigurationRoot configuracao);
    }
}
