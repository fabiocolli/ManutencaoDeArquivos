namespace ServicoMantemArquivos.Teste.Servico
{
    public class TestaServicoManterArquivo
    {
        [Fact(DisplayName = "Deve Excluir Arquivos quando for maior que o periodo estipulado")]
        public void DeveExcluirArquivo_SeDataDeCriacaoForMaiorQuePeriodoConfigurado()
        {

        }


        [Fact(DisplayName = "Não deve excluir o arquivo quando quando for menor que o período estipulado")]
        public void NaoDeveExcluirArquivo_SeDataDeCriacaoForMenorOuIgualAoPeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "Deve Excluir Arquivos quando for maior que o periodo estipulado quando estiver dentro de subpastas")]
        public void DeveExcluirArquivosDeSubpastas_SeDataDeCriacaoForMaiorQuePeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "Não deve excluir o arquivo quando quando for menor que o período estipulado")]
        public void NaoDeveExcluirArquivosDeSubpastas_SeDataDeCriacaoForMenorQuePeriodoConfigurado()
        {

        }

        [Fact(DisplayName = "Deve ler a configuraçáo de período de tempo do arquivo app.Config")]
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

        [Fact(DisplayName = "Deve logar os arquivos excluídos")]
        public void DeveLogarExclusaoDeArquivo()
        {

        }

        [Fact(DisplayName = "Deve lançar exceção e logar quando o arquivo estiver inválido ou corrompido")]
        public void DeveLancarExcecao_SeArquivoConfigEstiverInvalidoOuCorrompido()
        {

        }

        [Fact(DisplayName = "Deve iniciar serviço corretamente")]
        public void DeveIniciarServicoComConfiguracoesCorretas()
        {

        }

        [Fact(DisplayName = "Não deve iniciar serviço quando as configurações estiverem erradas")]
        public void NaoDeveIniciarServico_SeConfiguracaoEstiverInvalida()
        {

        }
    }
}