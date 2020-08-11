using System;
using System.ServiceProcess;

namespace WcfServiceLibrary.WindowsServiceHost
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {

#if DEBUG
            Service1 service1 = new Service1();
            service1.StartInDebug();

            System.Threading.Thread.Sleep(new TimeSpan(1, 0, 0));
#else

            ServiceBase[] ServicesToRun;
            ServicesToRun = new ServiceBase[]
            {
                new Service1()
            };
            ServiceBase.Run(ServicesToRun);
#endif

        }
    }
}
