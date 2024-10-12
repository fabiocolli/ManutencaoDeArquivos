using Dominio.ManutencaoArquivos.Entidades;

namespace Dominio.ManutencaoArquivos.Interface
{
    public interface IRegraExclusaoDeArquivo
    {
        void MarcarArquivoQuePodeSerExcluido(Arquivo arquivo, int periodoParaExclusao);
    }
}
