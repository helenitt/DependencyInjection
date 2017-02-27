using System;
using Shared;

namespace DependencyInjectionExample
{
    class Program
    {
        public static void Main(string[] args)
        {
            Student student; 
            var configAge = new Config();
            var ageLimit = Int32.Parse(configAge.AgeLimit);
            var sentinel = "y";
            int age;

            Console.WriteLine("\n***************\nStudent Creator\n***************");
            Console.WriteLine("\nAge Limit is: {0}\n", ageLimit);

            while (sentinel.Equals("y"))
            {
                student = new Student(new LoggerOne(), configAge);
                Console.Write("Enter Students Name: ");
                student.Name = Console.ReadLine();
                Console.Write("Enter Students Age: ");
                age = Convert.ToInt32(Console.ReadLine());
                while (age < ageLimit)
                {
                    Console.Write("\nSorry too young! Enter Students Age: ");
                    age = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("\nNew Student Created\nName: {0} \nAge: {1}", student.Name, age);
                Console.Write("\nWould you like to add a student? y/n: ");
                sentinel = Console.ReadLine();
            }

            student = new Student(new LoggerTwo(), configAge);
            Console.Write("\nEnter Students Name: ");
            student.Name = Console.ReadLine();
            Console.Write("Enter Students Age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nNew Student Created\nName: {0} \nAge: {1}", student.Name, age);
            
            Console.ReadLine();
        }
    }
}
