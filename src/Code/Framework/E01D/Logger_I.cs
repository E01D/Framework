namespace Root.Code.Framework.E01D
{
    public interface Logger_I
    {
        LogEntry_I LogCritical(System.Exception exception);

        LogEntry_I LogCritical(System.Exception exception, string message);

        LogEntry_I LogException(System.Exception exception);

        LogEntry_I LogException(System.Exception exception, string message);

        LogEntry_I LogError(string message);

        LogEntry_I LogWarning(string message);

        LogEntry_I LogInfo(string message);

        LogEntry_I LogTrace(string message);

        LogEntry_I LogDebug(string message);

        LogEntry_I LogDebug(object message);



    }
    
}
