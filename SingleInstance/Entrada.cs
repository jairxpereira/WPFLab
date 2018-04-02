using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleInstance
{
    class Entrada: Microsoft.VisualBasic.ApplicationServices.WindowsFormsApplicationBase
    {

        protected SingleInstance.App app;

        [STAThread]
        public static void Main(string[] args)
        {
            SingleInstance.Entrada entrada =
            new SingleInstance.Entrada();
            entrada.Run(args);            
        }


        public Entrada()
        {
            this.IsSingleInstance = true;

        }

        protected override bool OnStartup(Microsoft.VisualBasic.ApplicationServices.StartupEventArgs e)
        {
            app = new SingleInstance.App();

            if (e.CommandLine.Count > 0)
            {
                String[] cmdLine = new string[1];
                cmdLine[0] = e.CommandLine[0];
                app.commandLine = cmdLine;


            }

            app.InitializeComponent();

            app.Run();


            
            return false;
        }

        // Direct multiple instances.
        protected override void OnStartupNextInstance(
        Microsoft.VisualBasic.ApplicationServices.StartupNextInstanceEventArgs e)
        { 

            if (e.CommandLine.Count > 0)
            {
                String[] cmdLine = new string[1];
                cmdLine[0] = e.CommandLine[0];
                app.commandLine = cmdLine;


            }

            SingleInstance.MainWindow wnd = (SingleInstance.MainWindow)app.MainWindow;
            wnd.addWindow();           

        }


    }
}
