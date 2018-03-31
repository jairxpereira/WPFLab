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

namespace WPFLab
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
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
    }
}
