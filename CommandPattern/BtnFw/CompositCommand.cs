using System;
using System.Collections.Generic;
using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    /// <summary>
    ///     CompositCommand is a command composed of commands that we can execute at one time.
    /// </summary>
    public class CompositCommand : ICommand
    {
        private readonly List<ICommandBase> _commandsList = new List<ICommandBase>();

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter = null)
        {
            foreach (var command in _commandsList)
                if (command.IsUndo)
                    command.ExecuteUndo();
                else
                    command.Execute(null);
        }

        public event EventHandler CanExecuteChanged;

        public ICommandBase AddCommand(ICommandBase cmd)
        {
            _commandsList.Add(cmd);
            return cmd;
        }

        public ICommandBase AddCommand(ICommandBase cmd, bool isUndo = false)
        {
            cmd.IsUndo = isUndo;
            _commandsList.Add(cmd);
            return cmd;
        }
    }
}