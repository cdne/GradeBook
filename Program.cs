using System;

namespace ConsoleApp5
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var book = new GradeBook("New York Public School GradeBook");

            while (true)
            {
                Console.WriteLine("Enter a grade or press q to exit: ");
                var input = Console.ReadLine();

                if (input == "q") break;

                try
                {
                    var grade = double.Parse(input);
                    book.AddGrade(grade);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("-----");
                }
            }

            var stats = book.GetStatistics();

            Console.WriteLine($"Lowest grade is {stats.Low}");
            Console.WriteLine($"Highest grade is {stats.High}");
            Console.WriteLine($"Average grade is {stats.Average:n1}");
            Console.WriteLine($"Average grade letter is {stats.Letter}");
        }
    }
}