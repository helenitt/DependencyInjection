using System;

namespace DependencyInjection
{
    class LoggerOne : ILogger
    {
        public void WriteToLog(string text)
        {
            Console.WriteLine(text);
        }
    }
}
