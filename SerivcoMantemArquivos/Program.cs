using System.ServiceProcess;

namespace SerivcoMantemArquivos
{
    internal static class Program
    {
        static void Main()
        {
            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new SerivcoMantemArquivos()
            };
            ServiceBase.Run(ServicesToRun);
        }
    }
}
