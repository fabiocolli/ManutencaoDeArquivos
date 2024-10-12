using FluentAssertions;
using Infraestrutura.ManutencaoArquivos.Interfaces;

namespace ServicoMantemArquivos.Teste.Infraestrturura
{
    public class TesteIntefaces
    {
        [Fact(DisplayName = "A interface de IServicoDeConfiguracao deve existir")]
        public void AInterfaceIConfiguracaoServiceDeveExistir()
        {
            // Arranjo
            var configuracaoService = typeof(IServicoDeConfiguracao);

            // Ação
            var configuracao = configuracaoService;

            // Assertiva
            configuracao.Should().NotBeNull();
        }

        [Fact(DisplayName = "A interface de IServicoArquivoDeSistema deve ter existir")]
        public void AInterfaceIServicoArquivoDeSistemaDeveExistir()
        {
            // Arranjo
            var servicoArquivoDeSistema = typeof(IServicoArquivoDeSistema);

            // Ação
            var servico = servicoArquivoDeSistema;

            // Assertiva
            servico.Should().NotBeNull();
        }

        [Fact(DisplayName = "A interface de IServicoDeConfiguracao deve ter o método de ObterConfiguracoes")]
    }
}
