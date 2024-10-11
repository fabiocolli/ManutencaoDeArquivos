using AplicacaoManutencaoServico.Interfaces;
using FluentAssertions;

namespace ServicoMantemArquivos.Teste.Aplicacao
{
    public class TesteInterface
    {
        [Fact(DisplayName = "A interface IArquivoService deve existir")]
        public void AInterfaceArquivoServiceDeveExistir()
        {
            //Arranjo
            var interfaceArquivoService = typeof(IServicoArquivo);

            //Assertiva
            interfaceArquivoService.Should().NotBeNull();
        }

        [Fact(DisplayName = "A interface IArquivoService deve ter um método ExcluirArquivosAntigos")]
        public void AInterfaceArquivoServiceDeveTerMetodoExcluirArquivosAntigos()
        {
            //Arranjo
            var interfaceArquivoService = typeof(IServicoArquivo);
            var metodoExcluirArquivosAntigos = interfaceArquivoService.GetMethod("ExcluirArquivosAntigos");

            //Assertiva
            metodoExcluirArquivosAntigos.Should().NotBeNull();
        }
    }
}
