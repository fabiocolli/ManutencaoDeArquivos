using Infraestrutura.ManutencaoArquivos.Classes;
using Microsoft.Extensions.Configuration;

namespace Infraestrutura.ManutencaoArquivos.Interfaces
{
    public interface IServicoDeConfiguracao
    {
        Configuracao ObterConfiguracoes(IConfigurationRoot configuiracoes);
    }
}
