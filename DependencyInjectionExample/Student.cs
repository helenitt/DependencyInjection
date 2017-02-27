using System;
using Shared;

namespace DependencyInjectionExample
{
    class Student
    {
        private int _age;

        public string Name { get; set; }
        public int Age { set { _age = value; } }

        public Student(ILogger logger, IConfig config)
        {
            //int.TryParse(config.AgeLimit, out _age);
            _age = Int32.Parse(config.AgeLimit);
            //_age = Convert.ToInt32(config.AgeLimit);
            logger.WriteToLog("\nCreating New Student");
        }
    }
}