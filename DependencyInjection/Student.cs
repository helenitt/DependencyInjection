namespace DependencyInjection
{
    class Student
    {
        public Student(ILogger logger)
        {
            logger.WriteToLog("New Student Created");
        }
    }
}
