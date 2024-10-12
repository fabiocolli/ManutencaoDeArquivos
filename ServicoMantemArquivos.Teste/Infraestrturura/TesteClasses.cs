using Dominio.ManutencaoArquivos.Entidades;
using FluentAssertions;
using Infraestrutura.ManutencaoArquivos.Classes;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using Microsoft.Extensions.Configuration;
using System.Reflection;

namespace ServicoMantemArquivos.Teste.Infraestrturura
{
    public class TesteClasses
    {
        [Fact(DisplayName = "A classe de Configuacao deve existir")]
        public void AClasseConfiguacaoDeveExistir()
        {
            // Arranjo
            var configuracao = typeof(Configuracao);

            // Ação
            var config = configuracao;

            // Assertiva
            config.Should().NotBeNull();
        }

        [Fact(DisplayName = "A classe de ServicoArquivosDeSistema deve existir")]
        public void AClasseServicoArquivosDeSistemaDeveExistir()
        {
            // Arranjo
            var servicoArquivosDeSistema = typeof(ServicoArquivosDeSistema);

            // Ação
            var servico = servicoArquivosDeSistema;

            // Assertiva
            servico.Should().NotBeNull();
        }

        [Fact(DisplayName = "A classe de ServicoArquivosDeSistema deve implementar a interface IServicoArquivoDeSistema")]
        public void AClasseServicoArquivosDeSistemaDeveImplementarInterfaceIServicoArquivoDeSistema()
        {
            // Arranjo
            var servicoArquivosDeSistema = typeof(ServicoArquivosDeSistema);
            var interfaceServicoArquivoDeSistema = typeof(IServicoArquivoDeSistema);

            // Ação
            var servico = servicoArquivosDeSistema.GetInterfaces();

            // Assertiva
            servico.Should().Contain(interfaceServicoArquivoDeSistema);
        }

        [Fact(DisplayName = "A classe de ServicoDeConfiguracao deve existir")]
        public void AClasseServicoDeConfiguracaoDeveExistir()
        {
            // Arranjo
            var servicoDeConfiguracao = typeof(ServicoDeConfiguracao);

            // Ação
            var servico = servicoDeConfiguracao;

            // Assertiva
            servico.Should().NotBeNull();
        }

        [Fact(DisplayName = "A classe de ServicoDeConfiguracao deve implementar a interface IServicoDeConfiguracao")]
        public void AClasseServicoDeConfiguracaoDeveImplementarInterfaceIServicoDeConfiguracao()
        {
            // Arranjo
            var servicoDeConfiguracao = typeof(ServicoDeConfiguracao);
            var interfaceServicoDeConfiguracao = typeof(IServicoDeConfiguracao);

            // Ação
            var servico = servicoDeConfiguracao.GetInterfaces();

            // Assertiva
            servico.Should().Contain(interfaceServicoDeConfiguracao);
        }

        [Fact(DisplayName = "O método ObterConfiguracoes da classe de ServicoDeConfiguracao Deve retornar um configuração válida")]
        public void OMetodoObterConfiguracoesDaClasseServicoDeConfiguracaoDeveRetornarUmaConfiguracaoValida()
        {
            // Arranjo
            var diretorio = Directory.GetCurrentDirectory();
            var servicoDeConfiguracao = new ServicoDeConfiguracao();
            var configuracao = new ConfigurationBuilder()
                            .SetBasePath(diretorio)
                            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                            .Build();

            // Ação
            var config = servicoDeConfiguracao.ObterConfiguracoes(configuracao);

            // Assertiva
            config.Should().NotBeNull();
            config.Should().BeOfType<Configuracao>();
            config.PastasRaizes.Should().NotBeNull();
            config.PeriodoDeTempoPermanenciaDoArquivo.Should().BeGreaterThan(0);
        }

        [Fact(DisplayName = "A classe de ServicoDeConfiguracao deve ter um método que faz o split das pastas raízes")]
        public void AClasseServicoDeConfiguracaoDeveTerMetodoQueFazSplitDasPastasRaizes()
        {
            // Arranjo
            var servicoDeConfiguracao = typeof(ServicoDeConfiguracao);
            var metodoSplitPastasRaizes = "SplitPastasRaizes";

            // Ação
            var metodos = servicoDeConfiguracao.GetMethods(BindingFlags.NonPublic | BindingFlags.Instance).Select(m => m.Name);

            // Assertiva
            metodos.Should().Contain(metodoSplitPastasRaizes);
        }

        [Fact(DisplayName = "O método SplitPastasRaizes da classe de ServicoDeConfiguracao deve retornar um List de string")]
        public void OMetodoSplitPastasRaizesDaClasseServicoDeConfiguracaoDeveRetornarUmIEnumerableDeString()
        {
            // Arranjo
            var servicoDeConfiguracao = new ServicoDeConfiguracao();
            var metodoSplitPastasRaizes = servicoDeConfiguracao.GetType()
                .GetMethod("SplitPastasRaizes", BindingFlags.NonPublic | BindingFlags.Instance);
            string pastas = "c:\\temp;C:\\Sempai";

            // Ação
            var pastasRaizes = metodoSplitPastasRaizes.Invoke(servicoDeConfiguracao, new object[] { pastas });

            // Assertiva
            pastasRaizes.Should().NotBeNull();
            pastasRaizes.Should().BeOfType<List<string>>();
        }

        [Fact(DisplayName = "A classe ServicoArquivosDeSistema precisa retornar uma lista de arquivos basedo na configuração de pastas")]
        public void AClasseServicoArquivosDeSistemaPrecisaRetornarUmaListaDeArquivosBaseadoNaConfiguracaoDePastas()
        {
            // Arranjo
            var servicoArquivosDeSistema = new ServicoArquivosDeSistema();
            var configuracao = new Configuracao
            {
                PastasRaizes = new List<string> { "C:\\temp" }
            };

            // Ação
            var arquivos = servicoArquivosDeSistema.ObterArquivosDasPastas(configuracao);

            // Assertiva
            arquivos.Should().NotBeNull();
            arquivos.Should().BeOfType<List<Arquivo>>();
        }
    }
}