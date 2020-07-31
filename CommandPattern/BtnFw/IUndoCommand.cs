using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.CommandPattern.BtnFw
{
    public  interface IUndoCommand
    {
        void ExecuteUndo();
    }
}
