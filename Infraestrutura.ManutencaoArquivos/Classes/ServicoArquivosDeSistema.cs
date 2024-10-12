using Dominio.ManutencaoArquivos.Entidades;
using Dominio.ManutencaoArquivos.Interface;
using Infraestrutura.ManutencaoArquivos.Interfaces;

namespace Infraestrutura.ManutencaoArquivos.Classes
{
    public class ServicoArquivosDeSistema : IServicoArquivoDeSistema
    {
        private readonly IRegraExclusaoDeArquivo _regraExclusaoDeArquivo;

        public ServicoArquivosDeSistema(IRegraExclusaoDeArquivo regraExclusaoDeArquivo)
        {
            _regraExclusaoDeArquivo = regraExclusaoDeArquivo;
        }

        public ServicoArquivosDeSistema()
        {

        }

        public bool ExcluirArquivo(Arquivo arquivo)
        {
            if (arquivo.PodeExcluir)
            {
                try
                {
                    File.Delete(arquivo.Caminho);
                }
                catch
                {
                    return false;
                }
            }

            return true;
        }

        public IEnumerable<Arquivo> ObterArquivosDasPastas(Configuracao configuracao)
        {
            List<Arquivo> arquivos = new List<Arquivo>();

            var pastas = configuracao.PastasRaizes;

            foreach (var pasta in pastas)
            {
                var arquivosDaPasta = ObterArquivosDaPasta(pasta, configuracao.PeriodoDeTempoPermanenciaDoArquivo);
                arquivos.AddRange(arquivosDaPasta);
            }

            return arquivos;
        }

        private IEnumerable<Arquivo> ObterArquivosDaPasta(string pasta, int periodoDeTempoPermanenciaDoArquivo)
        {
            List<Arquivo> arquivos = new List<Arquivo>();

            var arquivosAtuais = Directory.GetFiles(pasta);
            foreach (var arquivoAtual in arquivosAtuais)
            {
                var infoArquivo = new FileInfo(arquivoAtual);
                var arquivo = new Arquivo(infoArquivo.FullName, infoArquivo.LastWriteTime);
                _regraExclusaoDeArquivo.MarcarArquivoQuePodeSerExcluido(arquivo, periodoDeTempoPermanenciaDoArquivo);
                arquivos.Add(arquivo);
            }

            var subpastas = Directory.GetDirectories(pasta);
            foreach (var subpasta in subpastas)
            {
                var arquivosDaSubpasta = ObterArquivosDaPasta(subpasta, periodoDeTempoPermanenciaDoArquivo);
                arquivos.AddRange(arquivosDaSubpasta);
            }

            return arquivos;
        }
    }
}
