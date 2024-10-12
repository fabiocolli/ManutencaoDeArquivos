using Dominio.ManutencaoArquivos.Entidades;
using Dominio.ManutencaoArquivos.Servicos;
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

        [Fact(DisplayName = "A classe RegraExclusaoDeArquivo deve retornar true quando a a diferença entre a data de criação e hoje em dias for maior que a do parâmetro")]
        public void RegraExclusaoDeArquivo_DeveRetornarTrueQuandoDiferencaEntreDataDeCriacaoEDataAtualForMaiorQueParametro()
        {
            // Arranjo
            var regradeExclusaoArquivo = new RegraExclusaoDeArquivo();
            var arquivo = new Arquivo("C:\\temp\\arquivo.txt", DateTime.Now.AddDays(-761));

            // Ação
            regradeExclusaoArquivo.MarcarArquivoQuePodeSerExcluido(arquivo, 760);

            // Assertiva
            arquivo.PodeExcluir.Should().BeTrue();
        }
    }
}
