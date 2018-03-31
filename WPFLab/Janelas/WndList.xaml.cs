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
    /// Lógica interna para WndList.xaml
    /// </summary>
    public partial class WndList : Window
    {
        public WndList()
        {
            InitializeComponent();
        }

         private void lst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (lst.SelectedItem == null) return;
            txtSelection.Text = String.Format(
            "You chose item at position {0}.\r\nChecked state is {1}.",
            lst.SelectedIndex,
            ((CheckBox)lst.SelectedItem).IsChecked);
        }

        private void lst_SelectionChanged(object sender, RoutedEventArgs e)
        {
            if (lst.SelectedItem == null) return;
            int ndx = lst.SelectedIndex;
            CheckBox chk = (CheckBox)lst.SelectedItem;


            txtSelection.Text = String.Format(
            "You chose item at position {0}.\r\nChecked state is {1}.",
            ndx, chk.IsChecked);
        }
    }
}
