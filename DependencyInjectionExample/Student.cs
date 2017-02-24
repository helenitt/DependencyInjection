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
               // An object reference is required for the none static field, method or 
               // property 'Shared.LoggerOne.AgeLimit.get'                
                _age = value;
            }
        }

        public Student(ILogger logger)
        {
            logger.WriteToLog("New Student Created");
        }
    }
}
