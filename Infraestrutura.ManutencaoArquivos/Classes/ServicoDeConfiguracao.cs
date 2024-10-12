using Infraestrutura.ManutencaoArquivos.Interfaces;
using Microsoft.Extensions.Configuration;

namespace Infraestrutura.ManutencaoArquivos.Classes
{
    public class ServicoDeConfiguracao : IServicoDeConfiguracao
    {
        public Configuracao ObterConfiguracoes(IConfigurationRoot configuiracoes)
        {
            var pastasRaizes = configuiracoes.GetSection("Configuracoes:PastasRaizes");
            var PeriodoConfiguradoEmDias = configuiracoes.GetSection("Configuracoes:PeriodoConfiguradoEmDias");
            int periodoDeTempoPermanenciaDoArquivo = 0;

            return new Configuracao
            {
                PastasRaizes = SplitPastasRaizes(pastasRaizes.Value),
                PeriodoDeTempoPermanenciaDoArquivo =
                int.TryParse(PeriodoConfiguradoEmDias?.Value, out periodoDeTempoPermanenciaDoArquivo)
                    ? periodoDeTempoPermanenciaDoArquivo : 1
            };
        }

        private List<string> SplitPastasRaizes(string pastasRaizes)
        {
            List<string> pastas = new List<string>();

            pastas.AddRange(pastasRaizes?.Split(";") ?? Array.Empty<string>());

            pastas.RemoveAll(pasta => string.IsNullOrWhiteSpace(pasta) || !Directory.Exists(pasta));

            return pastas;
        }
    }
}
