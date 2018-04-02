using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SingleInstance
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
        public string[] commandLine;


        private void SingleInstance_onStart(object sender, StartupEventArgs e)
        {
            
            commandLine = e.Args;
        }
    }
}
