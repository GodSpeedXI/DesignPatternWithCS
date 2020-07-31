using System.Windows.Input;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public interface ICommandBase : ICommand, IUndoCommand
    {
        public bool IsUndo { get; set; }
    }
}