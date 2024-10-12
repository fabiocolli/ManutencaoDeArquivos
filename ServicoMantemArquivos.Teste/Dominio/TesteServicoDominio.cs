using Dominio.ManutencaoArquivos.Interface;
using Dominio.ManutencaoArquivos.Servicos;
using FluentAssertions;

namespace ServicoMantemArquivos.Teste.Dominio
{
    public class TesteServicoDominio
    {
        [Fact(DisplayName = "A classe de RegraExclusaoDeArquivoService deve existir")]
        public void AClasseRegraExclusaoDeArquivoServiceDeveExistir()
        {
            // Arranjo
            var servicoExclusao = typeof(ServicoDeRegraExclusaoDeArquivo);

            // Ação
            var servico = servicoExclusao;

            // Assertiva
            servico.Should().NotBeNull();
        }

        [Fact(DisplayName = "A classe de RegraExclusaoDeArquivoService deve implementar a interface IRegraExclusaoDeArquivo")]
        public void AClasseRegraExclusaoDeArquivoServiceDeveImplementarInterfaceIRegraExclusaoDeArquivo()
        {
            // Arranjo
            var servicoExclusao = typeof(ServicoDeRegraExclusaoDeArquivo);
            var interfaceRegraExclusao = typeof(IRegraExclusaoDeArquivo);

            // Ação
            var servico = servicoExclusao.GetInterfaces();

            // Assertiva
            servico.Should().Contain(interfaceRegraExclusao);
        }
    }
}
