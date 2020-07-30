using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.StategyPattern.Filters
{
    public interface IFilter
    {
        void Apply(ref string file);
    }
}
