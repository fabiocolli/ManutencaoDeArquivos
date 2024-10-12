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

        public IEnumerable<Arquivo> ObterArquivosDasPastas(Configuracao configuracao)
        {
            List<Arquivo> arquivos = new List<Arquivo>();

            var pastas = configuracao.PastasRaizes;

            foreach (var pasta in pastas)
            {
                var arquivosDaPasta = ObterArquivosDaPasta(pasta);
                arquivos.AddRange(arquivosDaPasta);
            }

            return arquivos;
        }

        private IEnumerable<Arquivo> ObterArquivosDaPasta(string pasta)
        {
            List<Arquivo> arquivos = new List<Arquivo>();

            var arquivosAtuais = Directory.GetFiles(pasta);
            foreach (var arquivoAtual in arquivosAtuais)
            {
                var infoArquivo = new FileInfo(arquivoAtual);
                var arquivo = new Arquivo(infoArquivo.FullName, infoArquivo.CreationTime);
                arquivos.Add(arquivo);
            }

            var subpastas = Directory.GetDirectories(pasta);
            foreach (var subpasta in subpastas)
            {
                var arquivosDaSubpasta = ObterArquivosDaPasta(subpasta);
                arquivos.AddRange(arquivosDaSubpasta);
            }

            return arquivos;
        }
    }
}
