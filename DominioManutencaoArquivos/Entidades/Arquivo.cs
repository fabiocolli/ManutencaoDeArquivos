namespace DominioManutencaoArquivos.Entidades
{
    public class Arquivo
    {
        public Arquivo()
        {

        }
        public Arquivo(string caminho, DateTime dataDeCriacao)
        {
            Caminho = caminho;
            DataDeCriacao = dataDeCriacao;
        }

        public string Caminho { get; }

        public DateTime DataDeCriacao { get; }
    }
}
