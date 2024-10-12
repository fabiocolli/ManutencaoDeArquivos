using Infraestrutura.ManutencaoArquivos.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infraestrutura.ManutencaoArquivos.Classes
{
    public class ServicoDeConfiguracao : IServicoDeConfiguracao
    {
        public Configuracao ObterConfiguracoes(IConfigurationRoot configuiracoes)
        {
            var pastasRaizes = configuiracoes.GetSection("Configuracoes:PastasRaizes");
            var periodoConfiguradoEmSegundos = configuiracoes.GetSection("Configuracoes:PeriodoConfiguradoEmSegundos");
            int periodoDeTempoPermanenciaDoArquivo = 0;

            return new Configuracao
            {
                PastasRaizes = SplitPastasRaizes(pastasRaizes.Value),
                PeriodoDeTempoPermanenciaDoArquivo =
                int.TryParse(periodoConfiguradoEmSegundos?.Value, out periodoDeTempoPermanenciaDoArquivo)
                    ? periodoDeTempoPermanenciaDoArquivo : 1
            };
        }

        private List<string> SplitPastasRaizes(string pastasRaizes)
        {
            List<string> pastas = new List<string>();

            pastas.AddRange(pastasRaizes?.Split(";") ?? Array.Empty<string>());

            return pastas;
        }
    }
}
