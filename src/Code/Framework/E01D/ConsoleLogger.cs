using System;

namespace Root.Code.Framework.E01D
{
    public class ConsoleLogger:Logger_I
    {
        public LogEntry_I LogCritical(System.Exception exception)
        {
            Console.WriteLine(exception?.Message);
            return null;
        }

        public LogEntry_I LogCritical(System.Exception exception, string message)
        {
            Console.WriteLine(exception?.Message);
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogException(System.Exception exception)
        {
            Console.WriteLine(exception?.Message);
            return null;
        }

        public LogEntry_I LogException(System.Exception exception, string message)
        {
            Console.WriteLine(exception?.Message);
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogError(string message)
        {
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogWarning(string message)
        {
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogInfo(string message)
        {
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogTrace(string message)
        {
            Console.WriteLine(message);
            return null;
        }

        public LogEntry_I LogDebug(object message)
        {
            return LogDebug(message.ToString());
        }

        public LogEntry_I LogDebug(string message)
        {
            Console.WriteLine(message);
            return null;
        }
    }
}
