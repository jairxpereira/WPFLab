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
    }
}
