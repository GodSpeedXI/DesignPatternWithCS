using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using DesignPatternPractice.CommandPattern.BtnFw;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    /// <summary>
    /// CompositCommand is a command composed of commands that we can execute at one time.
    /// </summary>
    public class CompositCommand : System.Windows.Input.ICommand
    {
        private List<ICommand> _commandsList = new List<ICommand>();

        public ICommand AddCommand(ICommand cmd)
        {
            _commandsList.Add(cmd);
            return cmd;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter = null)
        {
            foreach (var command in _commandsList)
            {
                command.Execute(null);
            }
        }

        public event EventHandler CanExecuteChanged;
    }
}
