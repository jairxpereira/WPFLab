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
    /// Lógica interna para WndBindingEx.xaml
    /// </summary>
    public partial class WndBindingEx : Window
    {
        public WndBindingEx()
        {
            InitializeComponent();
        }

        private void btnChangeTitle_onClick(object sender, RoutedEventArgs e)
        {
            this.Title = DateTime.Now.ToString();
        }
    }
}
