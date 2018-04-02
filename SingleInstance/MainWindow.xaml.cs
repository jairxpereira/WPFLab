using System;
using System.Collections.Generic;
using System.Linq;
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

namespace SingleInstance
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Window> janelas = null;
        private int janelaIndex;



        public MainWindow()
        {
            InitializeComponent();
            janelas = new List<Window>();
            janelaIndex = 0;



        }

        public void addWindow( Window wnd )
        {
            janelas.Add(wnd);
            listJanelas.Items.Add(wnd.Title);
            janelaIndex++;

            String[] cmd = null;
            SingleInstance.App app = (SingleInstance.App)Application.Current;
            cmd = app.commandLine;
            String cmd_str = null;

            if (cmd != null )
            foreach ( string str in cmd )
            {
                cmd_str += str + " ";

            }           

            bool bfile = System.IO.File.Exists(cmd_str);
            if (bfile== true)
            {
                cmd_str = System.IO.File.ReadAllText(cmd_str);

            }



            if (cmd == null) cmd_str = "sem linha de argumentos";
            ((WndEditor)wnd).addText(cmd_str);

          
                          

           


        }

        public List<Window> getJanelas()
        {
            return janelas;
        }

        private void btnNovaJanela_onClick(object sender, RoutedEventArgs e)
        {
            Window wnd = new WndEditor();
            wnd.Title = "Janela_" + janelaIndex.ToString();
            wnd.Owner = this;
            addWindow(wnd);
            wnd.Show();
        }       

        private void ownd_onInit(object sender, RoutedEventArgs e)
        {
            this.btnNovaJanela_onClick(null, null);
        }

        public void addWindow()
        {
            this.btnNovaJanela_onClick(null, null);
        }
    }
}
