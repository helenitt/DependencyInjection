using System;

namespace Shared
{
    public class LoggerTwo: ILogger
    {
        public void WriteToLog(string text)
        {
            Console.WriteLine("***********\n {0}\n***********", text);
        }

        public int AgeLimit { get; set; }
    }
}
