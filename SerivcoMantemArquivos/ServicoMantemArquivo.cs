using System.ServiceProcess;

namespace SerivcoMantemArquivos
{
    public partial class SerivcoMantemArquivos : ServiceBase
    {
        public SerivcoMantemArquivos()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {

        }

        protected override void OnStop()
        {
        }
    }
}
