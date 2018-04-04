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
    /// Lógica interna para WndTree.xaml
    /// </summary>
    public partial class WndTree : Window
    {
        public WndTree()
        {
            InitializeComponent();
        }

        private void otree_onSelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

            return;




        }

        private void otree_onMouseUp(object sender, MouseButtonEventArgs e)
        {

            TreeViewItem item = (TreeViewItem)otree.SelectedItem;
            lbStatus.Content = item.Header.ToString();
           
        }
    }
}
