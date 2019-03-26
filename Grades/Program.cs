using System;

namespace Grades
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            SpeechSynthesizer 

            GradeBook book = new GradeBook();
            book.AddGrade(94);
            book.AddGrade(76.5f);
            book.AddGrade(68);

            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowerestGrade);
        }
    }
}
