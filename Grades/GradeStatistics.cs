using System;
namespace Grades
{
    class GradeStatistics
    {

        public GradeStatistics()
        {
            HighestGrade = 0;
            LowerestGrade = float.MaxValue;
        }


        public GradeStatistics ComputeStatistics()
        {

            GradeStatistics stats = new GradeStatistics();

            float sum = 0;
            foreach (float grade in GradeBook.grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowerestGrade = Math.Min(grade, stats.LowerestGrade);
                sum = sum + grade;
            }


            stats.AverageGrade = sum / grades.Count;
            return stats;


        }



        public float AverageGrade;
        public float HighestGrade;
        public float LowerestGrade;
    }
}
