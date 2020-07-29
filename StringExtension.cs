using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternPractice
{
    public static class StringExtension 
    {
        /// <summary>
        /// Just WriteLine to the console.
        /// </summary>
        /// <param name="str">msg to write</param>
        public static void Dump(this String str)
        {
            Console.WriteLine(str);
        }
    }
}
