using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ImageLibrary;


namespace WPFLab 
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool bUriRelative;

        public MainWindow()
        {
            InitializeComponent();
            bUriRelative = true;
        }

        private void btnWindowText_onClick(object sender, RoutedEventArgs e)
        {
            Window wnd = new Janelas.WndText();
            wnd.Show();

        }

        private void btnWindowList_onClick(object sender, RoutedEventArgs e)
        {
            Window wnd = new Janelas.WndList();
            wnd.Show();

        }

        private void btnRanged_onClick(object sender, RoutedEventArgs e)
        {
            Window wnd = new Janelas.WndRanged();
            wnd.Show();


        }

        private void btnWindowDatas_onClick(object sender, RoutedEventArgs e)
        {
            Window wnd = new Janelas.WndDates();
            wnd.Show();

        }

        private void btnTreeWindow_onClick(object sender, RoutedEventArgs e)
        {
            var wnd = new Janelas.WndTree();
            wnd.Show();
        }


        private void btnBinding_onClick(object sender, RoutedEventArgs e)
        {
            var wnd = new Janelas.WndBinding();
            wnd.Show();
        }

        private void btnSplash_onClick(object sender, RoutedEventArgs e)
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

        private void btnCommand_onClick(object sender, RoutedEventArgs e)
        {
            var wnd = new Janelas.WndCommand();
            wnd.Show();
        }

        // btnGetResourceList
        private void btnGetResourceList_onClick(object sender, RoutedEventArgs e)
        {

            Assembly assembly = Assembly.GetAssembly(this.GetType());
            string resourceName = assembly.GetName().Name + ".g";
            System.Resources.ResourceManager rm = new System.Resources.ResourceManager(resourceName, assembly);
            using (ResourceSet set =
            rm.GetResourceSet(System.Globalization.CultureInfo.CurrentCulture, true, true))
            {
                StringBuilder sb = new StringBuilder();
                foreach (DictionaryEntry res in set)
                {
                    String str = res.Key.ToString() + "\n\r";
                    sb.Append(str );

                }

                Uri uri = null;
                if (bUriRelative == true)
                uri = new Uri("/Images/Pic2.png", UriKind.Relative);
                else
                    uri = new Uri("pack://application:,,,/Images/Pic0.png");

                bUriRelative = !bUriRelative;

                sb.Append(uri.ToString());

                img.Source = new BitmapImage(uri);                
                Sound.Play();
                MessageBox.Show(sb.ToString(), resourceName);
                


            }

        }

        private void ResourceOtherLib_onClick(object sender, RoutedEventArgs e)
        {
            Uri uri = null;
            if (bUriRelative == true)
            {
                uri = new Uri("ImageLibrary;component/images/Pic0.png", UriKind.Relative);
                img.Source = new BitmapImage(uri);
                Tools.sayHello("Uri relativa");
            }
                
            else
            {
                uri = new Uri("pack://application:,,,/ImageLibrary;component/images/Pic1.png");
                img.Source = new BitmapImage(uri);
                Tools.sayHello("Uri absoluta");
            }
                

            

            bUriRelative = !bUriRelative;

            // new Uri("ImageLibrary;component/images/winter.jpg", UriKind.Relative));
           
        }
    }
}
