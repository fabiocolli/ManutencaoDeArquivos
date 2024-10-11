using DominioManutencaoArquivos.Entidades;
using FluentAssertions;

namespace ServicoMantemArquivos.Teste.Dominio
{
    public class TestesDominio
    {
        [Fact(DisplayName = "A classe Arquivo deve ser criada com os parâmetros obrigatórios")]
        public void Arquivo_DeveSerCriadoComParametrosObrigatorios()
        {
            // Arranjo
            var caminho = "C:\\temp\\arquivo.txt";
            var dataDeCriacao = DateTime.Now;

            // Ação
            var arquivo = new Arquivo(caminho, dataDeCriacao);

            // Assertiva
            arquivo.Caminho.Should().Be(caminho);
            arquivo.DataDeCriacao.Should().Be(dataDeCriacao);
        }
    }
}
