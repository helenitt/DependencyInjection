<Query Kind="Program" />

void Main()
{
	var firstStudent = new Student(new LoggerOne());
	Console.WriteLine();
	var secondStudent = new Student(new LoggerTwo());
	Console.WriteLine();
	var thirdStudent = new Student(new LoggerOne());
}

public class Student
{
    public Student(ILogger logger)
    {
        logger.WriteToLog("New student created");
    }
}

public interface ILogger
{
    void WriteToLog(string text);
}

public class LoggerOne : ILogger
{
    public void WriteToLog(string text)
    {
        Console.WriteLine(text);
    }
}

public class LoggerTwo : ILogger
{
    public void WriteToLog(string text)
    {
        Console.WriteLine("***********\n {0}\n***********", text);
    }
}