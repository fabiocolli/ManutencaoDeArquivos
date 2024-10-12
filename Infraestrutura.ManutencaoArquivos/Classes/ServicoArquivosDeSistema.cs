using Dominio.ManutencaoArquivos.Entidades;
using Infraestrutura.ManutencaoArquivos.Interfaces;

namespace Infraestrutura.ManutencaoArquivos.Classes
{
    public class ServicoArquivosDeSistema : IServicoArquivoDeSistema
    {
        public bool ExcluirArquivo(Arquivo arquivo)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Arquivo> ObterArquivosDasPastas(string[] pastasRaizes)
        {
            throw new NotImplementedException();
        }
    }
}
