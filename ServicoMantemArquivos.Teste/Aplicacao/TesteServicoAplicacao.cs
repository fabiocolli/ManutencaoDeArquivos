using Aplicacao.ManutencaoDeArquivo.Interfaces;
using Aplicacao.ManutencaoDeArquivo.Servico;
using Dominio.ManutencaoArquivos.Interface;
using FluentAssertions;
using Infraestrutura.ManutencaoArquivos.Interfaces;
using System.Reflection;

namespace ServicoMantemArquivos.Teste.Aplicacao
{
    public class TesteServicoAplicacao
    {
        [Fact(DisplayName = "A classe de ServicoArquivo deve existir")]
        public void AClasseServicoArquivoDeveExistir()
        {
            // Arranjo
            var servicoArquivo = typeof(ServicoArquivo);

            // Ação
            var servico = servicoArquivo;

            // Assertiva
            servico.Should().NotBeNull();
        }

        [Fact(DisplayName = "A classe de ServicoArquivo deve implementar a interface IServicoArquivo")]
        public void AClasseServicoArquivoDeveImplementarInterfaceIServicoArquivo()
        {
            // Arranjo
            var servicoArquivo = typeof(ServicoArquivo);
            var interfaceServicoArquivo = typeof(IServicoArquivo);

            // Ação
            var servico = servicoArquivo.GetInterfaces();

            // Assertiva
            servico.Should().Contain(interfaceServicoArquivo);
        }

        [Fact(DisplayName = "A classe de ServicoArquivo deve conter as propriedades IRegraExclusaoDeArquivo, IConfiguracaoService, IServicoArquivoDeSistema")]
        public void AClasseServicoArquivoDeveConterPropriedadesIRegraExclusaoDeArquivoIConfiguracaoServiceIFileSystemService()
        {
            // Arranjo
            var servicoArquivo = typeof(ServicoArquivo);
            var propriedadeRegraExclusaoDeArquivo = typeof(IRegraExclusaoDeArquivo);
            var propriedadeConfiguracaoService = typeof(IServicoDeConfiguracao);
            var propriedadeServicoArquivoDeSistema = typeof(IServicoArquivoDeSistema);

            // Ação
            var propriedades = servicoArquivo
                .GetFields(BindingFlags.NonPublic | BindingFlags.Public | BindingFlags.Instance)
                .Select(p => p.FieldType.Name);

            // Assertiva
            propriedades.Should().Contain(propriedadeRegraExclusaoDeArquivo.Name);
            propriedades.Should().Contain(propriedadeConfiguracaoService.Name);
            propriedades.Should().Contain(propriedadeServicoArquivoDeSistema.Name);
        }
    }
}
