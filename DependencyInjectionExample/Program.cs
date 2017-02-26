using System;
using Shared;

namespace DependencyInjectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            var firstStudent = new Student(new LoggerOne(), new Config());
            Console.Write("Enter Students Name: ");
            firstStudent.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            var age = Convert.ToInt32(Console.ReadLine());

            var configAge = new Config();
            var ageLimit = Int32.Parse(configAge);
            while (age < ageLimit)
            {
                Console.WriteLine("Sorry to young!");
                Console.Write("Enter Students Age: ");
                age = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine();

            var secondStudent = new Student(new LoggerOne(), new Config());
            Console.Write("Enter Students Name: ");
            secondStudent.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            secondStudent.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            var thirdStudent = new Student(new LoggerOne(), new Config());
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
