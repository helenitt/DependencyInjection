using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstStudent = new Student(new LoggerOne());
            Console.WriteLine();
            var secondStudent = new Student(new LoggerTwo());
            Console.WriteLine();
            var thirdStudent = new Student(new LoggerOne());

            Console.ReadLine();
        }
    }
}
