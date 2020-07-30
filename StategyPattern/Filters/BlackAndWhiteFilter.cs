using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice.StategyPattern.Filters
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(ref string file)
        {
            ("Applying BlackAndWhiteFilter to " + file).Dump();
            file += " is now black and white";
        }
    }
}
