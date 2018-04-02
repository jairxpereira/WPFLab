using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace WPFLab
{
    /// <summary>
    /// Interação lógica para App.xaml
    /// </summary>
    public partial class App : Application
    {
       

            public App()
        {
            SplashScreen quadro = new SplashScreen("images/splash.png");
            // Show the splash screen.
            // The true parameter sets the splashScreen to fade away automatically
            // after the first window appears.
            
            quadro.Show(false);

            System.Threading.Thread.Sleep(2000);
            TimeSpan timeSpan = new TimeSpan(0, 0, 3);
            quadro.Close(timeSpan);

        }

    }
}
