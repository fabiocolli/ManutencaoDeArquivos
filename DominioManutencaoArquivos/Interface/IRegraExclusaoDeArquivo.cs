using DominioManutencaoArquivos.Entidades;

namespace DominioManutencaoArquivos.Interface
{
    public interface IRegraExclusaoDeArquivo
    {
        bool PodeExcluirArquivo(Arquivo arquivo, int idadeDoArquivo);
    }
}
