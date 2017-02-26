using System;

namespace Shared
{
    public class LoggerOne : ILogger
    {
        public void WriteToLog(string text)
        {
            Console.WriteLine(text);
        }
    }
}
