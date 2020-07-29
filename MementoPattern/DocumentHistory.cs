using System.Collections.Generic;
using System.Linq;

namespace DesignPatternPractice.MementoPattern
{
    /// <summary>
    /// Memento is a design pattern used to handle undo mechanism the content.
    /// This class is designed as Caretaker
    /// </summary>
    public class DocumentHistory
    {
        private List<DocumentState> _editStates = new List<DocumentState>();

        public void push(DocumentState state)
        {
            _editStates.Add(state);
        }

        public DocumentState pop()
        {
            var lastState = _editStates.Last();
            _editStates.Remove(lastState);
            return lastState;
        }
    }
}
