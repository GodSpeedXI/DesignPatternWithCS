using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.StatePattern
{
    /// <summary>
    /// StatePattern is a design pattern used for changing state of the object.
    /// This class is designed as State
    /// </summary>
    public interface IDestination
    {
        string Direction();
        int ETA();
    }
}
