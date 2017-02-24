using System;
using Shared;


namespace DependencyInjectionExample
{
    class Student
    {
        private int _age;

        public string Name { get; set; }

        public int Age
        {
            set
            {
                if (value < AgeLimit)
                    Console.WriteLine("Sorry to young!");
                else
                {
                    _age = value;
                }
            }
        }

        public Student(ILogger logger)
        {
            logger.WriteToLog("New Student Created");
        }
    }
}
