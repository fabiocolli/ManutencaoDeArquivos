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
        public void AInterfaceIServicoDeConfiguracaoDeveTerMetodoObterConfiguracoes()
        {
            // Arranjo
            var configuracaoService = typeof(IServicoDeConfiguracao);
            var metodoObterConfiguracoes = "ObterConfiguracoes";

            // Ação
            var metodos = configuracaoService.GetMethods().Select(m => m.Name);

            // Assertiva
            metodos.Should().Contain(metodoObterConfiguracoes);
        }

        [Fact(DisplayName = "A interface de IServicoArquivoDeSistema deve ter o método de ObterArquivos das pastas")]
        public void AInterfaceIServicoArquivoDeSistemaDeveTerMetodoObterArquivosDasPastas()
        {
            // Arranjo
            var servicoArquivoDeSistema = typeof(IServicoArquivoDeSistema);
            var metodoObterArquivosDasPastas = "ObterArquivosDasPastas";

            // Ação
            var metodos = servicoArquivoDeSistema.GetMethods().Select(m => m.Name);

            // Assertiva
            metodos.Should().Contain(metodoObterArquivosDasPastas);
        }

        [Fact(DisplayName = "A interface de IServicoArquivoDeSistema deve ter o método de Excluir arquivo")]
        public void AInterfaceIServicoArquivoDeSistemaDeveTerMetodoExcluirArquivo()
        {
            // Arranjo
            var servicoArquivoDeSistema = typeof(IServicoArquivoDeSistema);
            var metodoExcluirArquivo = "ExcluirArquivo";

            // Ação
            var metodos = servicoArquivoDeSistema.GetMethods().Select(m => m.Name);

            // Assertiva
            metodos.Should().Contain(metodoExcluirArquivo);
        }

        [Fact(DisplayName = "A interface de IServicoDeConfiguracao deve ter o método ObterConfiguracoes que tem um parâmetro do tipo ConfigurationBuilder")]
        public void AInterfaceIServicoDeConfiguracaoDeveTerMetodoObterConfiguracoesComParametroConfigurationBuilder()
        {
            // Arranjo
            var configuracaoService = typeof(IServicoDeConfiguracao);
            var parametroConfigurationBuilder = "IConfigurationRoot";

            // Ação
            var parametros = configuracaoService.GetMethods().SelectMany(m => m.GetParameters()).Select(p => p.ParameterType.Name);

            // Assertiva
            parametros.Should().Contain(parametroConfigurationBuilder);
        }
    }
}
