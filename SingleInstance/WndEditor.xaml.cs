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

namespace SingleInstance
{
    /// <summary>
    /// Lógica interna para WndEditor.xaml
    /// </summary>
    public partial class WndEditor : Window
    {
        public WndEditor()
        {
            InitializeComponent();
        }

        public void addText (string str)
        {
            txtEditor.Text = "";
            txtEditor.Text += str;

        }
    }
}
