using Dominio.ManutencaoArquivos.Entidades;

namespace Dominio.ManutencaoArquivos.Interface
{
    public interface IRegraExclusaoDeArquivo
    {
        bool PodeExcluirArquivo(Arquivo arquivo, int idadeDoArquivo);
    }
}
