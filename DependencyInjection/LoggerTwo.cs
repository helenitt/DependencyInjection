using System;

namespace DependencyInjection
{
    class LoggerTwo : ILogger
    {
        public void WriteToLog(string text)
        {
            Console.WriteLine("*******\n{0}\n*******", text);
        }
    }
}
