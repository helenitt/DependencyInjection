using System;
using Shared;

namespace DependencyInjectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstStudent = new Student(new LoggerOne());
            Console.Write("Enter Students Name: ");
            firstStudent.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            firstStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var secondStudent = new Student(new LoggerTwo());
            Console.Write("Enter Students Name: ");
            secondStudent.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            secondStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var thirdStudent = new Student(new LoggerOne());
            Console.Write("Enter Students Name: ");
            thirdStudent.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            thirdStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("\n\nThe Students Names: {0}, {1} and {2}"
                              , firstStudent.Name, secondStudent.Name, thirdStudent.Name);
            Console.ReadLine();
        }
    }
}
