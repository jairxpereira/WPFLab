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
    /// Lógica interna para WndMultipleBinding.xaml
    /// </summary>
    public partial class WndMultipleBinding : Window
    {
        public WndMultipleBinding()
        {
            InitializeComponent();
        }

        private void btnManualUpdate_onClick(object sender, RoutedEventArgs e)
        {
            // Get the binding that's applied to the text box.
            BindingExpression binding = txtManualUpdate.GetBindingExpression(TextBox.TextProperty);
            // Update the linked source (the TextBlock).
            binding.UpdateSource();
        }
    }
}
