using Dominio.ManutencaoArquivos.Entidades;

namespace Infraestrutura.ManutencaoArquivos.Interfaces
{
    public interface IServicoArquivoDeSistema
    {
        IEnumerable<Arquivo> ObterArquivosDasPastas(string[] pastasRaizes);
        bool ExcluirArquivo(Arquivo arquivo);
    }
}
