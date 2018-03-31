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
    /// Lógica interna para WndRanged.xaml
    /// </summary>
    public partial class WndRanged : Window
    {
        public WndRanged()
        {
            InitializeComponent();
        }

        private void mySlider_onValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbStatus.Content = mySlider.Value.ToString();

        }

        private void bar_onValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            lbStatus.Content = bar.Value.ToString();
        }
    }
}
