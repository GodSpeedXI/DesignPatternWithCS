using System;

namespace DesignPatternPractice.MementoPattern
{
    public static class MementoTest
    {
        /// <summary>
        /// This class is used for testing MementoPattern
        /// </summary>
        public static void Testing()
        {
            var originator = new Document();
            var history = new DocumentHistory();

            originator.SetContent("s1", "tahoma");
            history.push(originator.CreateState());

            originator.SetContent("s2", "saraban");
            history.push(originator.CreateState());

            originator.SetContent("s3", "time new roman");
            originator.Restore(history.pop());
            originator.Restore(history.pop());

            Console.WriteLine("Content: {0} \nFontName: {1} \nFontSize: {2}", 
                originator.GetContent(), originator.GetFontName(), originator.GetFontSize());
        }
    }
}
