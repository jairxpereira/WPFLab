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
    /// Lógica interna para WndCommand.xaml
    /// </summary>
    public partial class WndCommand : Window
    {
        private bool bNovo;

        public WndCommand()
        {

            ApplicationCommands.New.Text = "Novo documento";
            InitializeComponent();
            bNovo = false;          

        }

        private void toggleNovo(object sender, RoutedEventArgs e) => bNovo = !bNovo;


        private void action_onNovo( object sender, ExecutedRoutedEventArgs e)
        {
            string temp = " source: " + e.Source.ToString();
            temp += "\n\r sender: " + sender.ToString();
            txtEditor.Text = "";
            txtEditor.Text = temp;

            MessageBox.Show("novo item selecionado!", "action_onNovo()");

            
        }

        private void jogarCommand_Executed( object sender , ExecutedRoutedEventArgs e)
        {
            string temp = " source: " + e.Source.ToString();
            temp += "\n\r sender: " + sender.ToString();
            txtEditor.Text = "";
            txtEditor.Text = temp;

            MessageBox.Show("item jogar selecionado!", "jogarCommand_Executed()");
        }

        private void app_Encerrar(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBoxResult res = MessageBoxResult.OK;
            string msg = "Você quer fechar a janela?";
            string title = this.Title;

            string temp = " source: " + e.Source.ToString();
            temp += "\n\r sender: " + sender.ToString();
            txtEditor.Text = "";
            txtEditor.Text = temp;

            res = MessageBox.Show(msg, title, MessageBoxButton.YesNo, MessageBoxImage.Question);

            if (res == MessageBoxResult.Yes)
                this.Close();
        }

        private void ownd_onLoaded(object sender, RoutedEventArgs e)
        {
            CommandBinding binding = new CommandBinding(ApplicationCommands.Close);
            binding.Executed += app_Encerrar;
            this.CommandBindings.Add(binding);
            btnSair.Command = ApplicationCommands.Close;
        }

        private void btnTeste_onClick(object sender, RoutedEventArgs e)
        {
            ApplicationCommands.New.Execute(null, btnTeste);

        }

        private void novoCommand_CanExecute(object sender, CanExecuteRoutedEventArgs e)
        {
            e.CanExecute = bNovo;

            if (bNovo == true)
                otool.Visibility = Visibility.Visible;
            else
                otool.Visibility = Visibility.Collapsed;


        }
    }
}
