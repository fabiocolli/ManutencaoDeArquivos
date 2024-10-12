using Dominio.ManutencaoArquivos.Entidades;
using Dominio.ManutencaoArquivos.Interface;

namespace Dominio.ManutencaoArquivos.Servicos
{
    public class RegraExclusaoDeArquivo : IRegraExclusaoDeArquivo
    {
        public void MarcarArquivoQuePodeSerExcluido(Arquivo arquivo, int periodoParaExclusao)
        {
            arquivo.PodeExcluir = arquivo.DataDeCriacao.AddDays(periodoParaExclusao) < DateTime.Now;
        }
    }
}
