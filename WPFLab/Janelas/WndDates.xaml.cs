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
using System.Windows.Shapes;

namespace WPFLab.Janelas
{
    /// <summary>
    /// Lógica interna para WndDates.xaml
    /// </summary>
    public partial class WndDates : Window
    {
        public WndDates()
        {
            InitializeComponent();
        }

        private void btnAction_onClick(object sender, RoutedEventArgs e)
        {
            String str = null;

            str = cal.SelectedDate.ToString();
            MessageBox.Show(str, "cal");

            str = odate.SelectedDate.ToString();
            MessageBox.Show(str, "odate");


        }
    }
}
