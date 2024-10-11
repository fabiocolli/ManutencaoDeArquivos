using AplicacaoManutencaoServico.Interfaces;
using AplicacaoManutencaoServico.Servico;
using FluentAssertions;

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
    }
}
