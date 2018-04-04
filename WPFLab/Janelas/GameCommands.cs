using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPFLab.Janelas
{
    public class GameCommands
    {
        private static RoutedUICommand jogar;

        static GameCommands()
        {
            // Initialize the command.
            InputGestureCollection inputs = new InputGestureCollection();
            inputs.Add(new KeyGesture(Key.J, ModifierKeys.Control, "Ctrl+J"));
            jogar = new RoutedUICommand(
            "jogar", "jogar", typeof(GameCommands), inputs);
        }
        public static RoutedUICommand Jogar
        {
            get { return jogar; }
        }
    }
}
