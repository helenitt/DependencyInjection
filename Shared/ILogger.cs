
namespace Shared
{
    public interface ILogger
    {
        void WriteToLog(string text);
        int AgeLimit { get; }
    }
}
