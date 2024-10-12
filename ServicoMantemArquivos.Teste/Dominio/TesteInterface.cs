using Dominio.ManutencaoArquivos.Entidades;
using Dominio.ManutencaoArquivos.Interface;
using FluentAssertions;

namespace ServicoMantemArquivos.Teste.Dominio
{
    public class TesteInterface
    {
        [Fact(DisplayName = "A Interface IRegraExcluirArquivo deve existir")]
        public void AInterfaceExcluirArquivoDeveExistir()
        {
            //Arranjo
            var interfaceRegraExclusaoArquivo = typeof(IRegraExclusaoDeArquivo);

            //Assertiva
            interfaceRegraExclusaoArquivo.Should().NotBeNull();
        }

        [Fact(DisplayName = "A Interface IRegraExcluirArquivo deve ter um método MarcarArquivoQuePodeSerExcluido")]
        public void AInterfaceExcluirArquivoDeveTerMetodoPodeExcluirArquivo()
        {
            //Arranjo
            var interfaceRegraExclusaoArquivo = typeof(IRegraExclusaoDeArquivo);
            var metodoPodeExcluirArquivo = interfaceRegraExclusaoArquivo.GetMethod("MarcarArquivoQuePodeSerExcluido");

            //Assertiva
            metodoPodeExcluirArquivo.Should().NotBeNull();
        }

        [Fact(DisplayName = "O método MarcarArquivoQuePodeSerExcluido da Interface IRegraExcluirArquivo deve ser dois parâmetros")]
        public void MetodoPodeExcluirArquivoDeveTerDoisParametros()
        {
            //Arranjo
            var interfaceRegraExclusaoArquivo = typeof(IRegraExclusaoDeArquivo);
            var metodoPodeExcluirArquivo = interfaceRegraExclusaoArquivo.GetMethod("MarcarArquivoQuePodeSerExcluido");

            //Assertiva
            metodoPodeExcluirArquivo.GetParameters().Should().HaveCount(2);
        }

        [Fact(DisplayName = "O primeiro parâmetro do método MarcarArquivoQuePodeSerExcluido da Interface IRegraExcluirArquivo deve ser do tipo Arquivo e do tipo int")]
        public void PrimeiroParametroMetodoPodeExcluirArquivoDeveSerArquivoEInt()
        {
            //Arranjo
            var interfaceRegraExclusaoArquivo = typeof(IRegraExclusaoDeArquivo);
            var metodoPodeExcluirArquivo = interfaceRegraExclusaoArquivo.GetMethod("MarcarArquivoQuePodeSerExcluido");

            //Assertiva
            metodoPodeExcluirArquivo.GetParameters()[0].ParameterType.Should().Be(typeof(Arquivo));
            metodoPodeExcluirArquivo.GetParameters()[1].ParameterType.Should().Be(typeof(int));
        }
    }
}
