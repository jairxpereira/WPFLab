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

        private void btnSetBinding_onClick(object sender, RoutedEventArgs e)
        {
            Binding binding = new Binding();
            binding.Source = sliderFontSizeEx;
            binding.Path = new PropertyPath("Value");
            binding.Mode = BindingMode.TwoWay;
            lblSampleTextEx.SetBinding(TextBlock.FontSizeProperty, binding);


            // Vamos mostrar o código-fonte:
            string msg = @"Binding binding = new Binding();
binding.Source = sliderFontSizeEx;
binding.Path = new PropertyPath(''Value'');
binding.Mode = BindingMode.TwoWay;
lblSampleTextEx.SetBinding(TextBlock.FontSizeProperty, binding);";
            string title = "Binding aplicado: ";
            MessageBox.Show(msg, title);
        }

        private void btnClearBinding_onClick(object sender, RoutedEventArgs e)
        {
            BindingOperations.ClearAllBindings(lblSampleTextEx);

            string msg = "BindingOperations.ClearAllBindings(lblSampleTextEx);";
            string title = "Limpeza de binding aplicado: ";
            MessageBox.Show(msg, title);


        }
    }
}
