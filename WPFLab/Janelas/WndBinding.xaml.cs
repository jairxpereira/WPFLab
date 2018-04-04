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
    /// Lógica interna para WndBinding.xaml
    /// </summary>
    public partial class WndBinding : Window
    {
        public WndBinding()
        {
            InitializeComponent();
        }

        private void btnSetLarge_onClick(object sender, RoutedEventArgs e)
        {
            sliderFontSize.Value = 30;
        }

        private void btnSetLargeEx_onClick(object sender, RoutedEventArgs e)
        {
            lblSampleText.FontSize = 30;
        }
    }
}
