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
    /// Lógica interna para WndText.xaml
    /// </summary>
    public partial class WndText : Window
    {
        public WndText()
        {
            InitializeComponent();
        }

        private void btnGetSelection_onClick(object sender, RoutedEventArgs e)
        {
            String str = null;

            str = txtEditor.SelectedText;
            if (str == null || str == "") return;

            String temp = null;

            temp = "(" + txtEditor.SelectionStart.ToString() + " , " + txtEditor.SelectionLength.ToString() + ") \n\r";


            txtFeedback.Text = temp + txtEditor.SelectedText;



        }

        private void btnSubmit_onClick(object sender, RoutedEventArgs e)
        {
            if (txtPassword.Password == txtConfirmPassword.Password)
                lbStatus.Content = "Password atualizada com sucesso!";
            else
                lbStatus.Content = "Há divergência na sua digitação!";

            MessageBox.Show(txtPassword.Password);

        }


    }
}
