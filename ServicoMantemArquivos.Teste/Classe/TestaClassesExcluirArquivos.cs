using AplicacaoManutencaoServico;
using FluentAssertions;

namespace ServicoMantemArquivos.Teste.Classe
{
    public class TestaClassesExcluirArquivos
    {
        [Fact(DisplayName = "A classe Excluir Arquivo eve existir")]
        public void AClasseExcluirArquivo_DeveExistir()
        {
            // Arrange
            var excluirArquivo = new ExcluirArquivo();

            // Act
            var resultado = excluirArquivo;

            // Assert
            resultado.Should().NotBeNull();
        }


    }
}
