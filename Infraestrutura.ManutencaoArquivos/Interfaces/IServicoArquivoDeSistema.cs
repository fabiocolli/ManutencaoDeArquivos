using Dominio.ManutencaoArquivos.Entidades;
using Infraestrutura.ManutencaoArquivos.Classes;

namespace Infraestrutura.ManutencaoArquivos.Interfaces
{
    public interface IServicoArquivoDeSistema
    {
        IEnumerable<Arquivo> ObterArquivosDasPastas(Configuracao configuracao);
        bool ExcluirArquivo(Arquivo arquivo);
    }
}
