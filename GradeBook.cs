using System;
using System.Collections.Generic;

namespace ConsoleApp5
{
    internal class GradeBook
    {
        private List<double> grades;
        private Statistics stats;

        public GradeBook(string bookName)
        {
            grades = new List<double>();
            stats = new Statistics();
        }

        public void AddGrade(double grade)
        {
            if (grade <= 100 && grade >= 0) grades.Add(grade);
            else Console.WriteLine("You entered an invalid grade");
        }

        public Statistics GetStatistics()
        {
            stats.Low = double.MaxValue;
            stats.High = double.MinValue;
            stats.Average = 0.0;

            for (int i = 0; i < grades.Count; i++)
            {
                stats.Low = Math.Min(grades[i], stats.Low);
                stats.High = Math.Max(grades[i], stats.High);
                stats.Average += grades[i];
            }

            stats.Average /= grades.Count;

            switch (stats.Average){
                case var d when d >= 90.0:
                    stats.Letter = 'A';
                    break;
                case var d when d >= 80.0:
                    stats.Letter = 'B';
                    break;
                case var d when d >= 70.0:
                    stats.Letter = 'C';
                    break;
                case var d when d >= 60.0:
                    stats.Letter = 'D';
                    break;
                default:
                    stats.Letter = 'F';
                    break;
            }
            return stats;
        }
    }
}