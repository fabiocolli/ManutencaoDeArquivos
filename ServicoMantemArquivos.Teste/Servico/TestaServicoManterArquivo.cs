namespace ServicoMantemArquivos.Teste.Servico
{
    public class TestaServicoManterArquivo
    {
        [Fact(DisplayName = "Deve Excluir Arquivos quando for maior que o periodo estipulado")]
        public void DeveExcluirArquivo_SeDataDeCriacaoForMaiorQuePeriodoConfigurado()
        {

        }


        [Fact(DisplayName = "N�o deve excluir o arquivo quando quando for menor que o per�odo estipulado")]
        public void NaoDeveExcluirArquivo_SeDataDeCriacaoForMenorOuIgualAoPeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "Deve Excluir Arquivos quando for maior que o periodo estipulado quando estiver dentro de subpastas")]
        public void DeveExcluirArquivosDeSubpastas_SeDataDeCriacaoForMaiorQuePeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "N�o deve excluir o arquivo quando quando for menor que o per�odo estipulado")]
        public void NaoDeveExcluirArquivosDeSubpastas_SeDataDeCriacaoForMenorQuePeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "Deve ler a configura��o de per�odo de tempo do arquivo app.Config")]
        public void DeveLerConfiguracaoDePeriodoEmSegundosDoAppConfig()
        {

        }

        [Fact(DisplayName = "Deve ler caminho raiz do arquivo app.COnfig")]
        public void DeveLerCaminhosDasPastasRaizesDoAppConfig()
        {

        }

        [Fact(DisplayName = "Deve separar as pastas raizes numa lista de caminhos")]
        public void DeveProcessarMultiplasPastasRaizesConfiguradas()
        {

        }

        [Fact(DisplayName = "Deve logar os arquivos exclu�dos")]
        public void DeveLogarExclusaoDeArquivo()
        {

        }

        [Fact(DisplayName = "Deve lan�ar exce��o e logar quando o arquivo estiver inv�lido ou corrompido")]
        public void DeveLancarExcecao_SeArquivoConfigEstiverInvalidoOuCorrompido()
        {

        }

        [Fact(DisplayName = "Deve iniciar servi�o corretamente")]
        public void DeveIniciarServicoComConfiguracoesCorretas()
        {

        }

        [Fact(DisplayName = "N�o deve iniciar servi�o quando as configura��es estiverem erradas")]
        public void NaoDeveIniciarServico_SeConfiguracaoEstiverInvalida()
        {

        }
    }
}