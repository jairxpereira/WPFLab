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
                wnd.Title = cmd_str;
                cmd_str = System.IO.File.ReadAllText(cmd_str);

            }


            

            if (cmd == null) cmd_str = "sem linha de argumentos";
            ((WndEditor)wnd).addText(cmd_str);

            JanelaPlaceHolder holder = new JanelaPlaceHolder(wnd);
            listJanelas.Items.Add(holder);


            this.Activate();
            wnd.Activate();

          
                          

           


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

        private void btnFecharJanela_onClick(object sender, RoutedEventArgs e)
        {
            int janela_id = listJanelas.SelectedIndex;
            if (janela_id < 0) return;

            JanelaPlaceHolder jph = (JanelaPlaceHolder) listJanelas.SelectedItem;
            janelas.Remove(jph.wnd);
            listJanelas.Items.RemoveAt(janela_id);
            jph.wnd.Close();
        }

        public  void removerJanela( Window wnd)
        {
            janelas.Remove(wnd);

            foreach ( object obj in listJanelas.Items)
            {
                JanelaPlaceHolder holder = (JanelaPlaceHolder)obj;
                if (holder.wnd == wnd) listJanelas.Items.Remove(holder);
            }

        }

        private void btnFecharApp_onClick(object sender, RoutedEventArgs e)
        {
            this.Close();            
            Application.Current.Shutdown();
        }
    }
}
