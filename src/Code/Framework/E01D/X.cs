using System;

namespace Root.Code.Framework.E01D
{
    public class X
    {
        private const string DisableCachingName = @"TestSwitch.LocalAppContext.DisableCaching";
        private const string DontEnableSchUseStrongCryptoName = @"Switch.System.Net.DontEnableSchUseStrongCrypto";

        /// <summary>
        /// Gets or sets the default logger used by the E01D framework.
        /// </summary>
        public static Logger_I Logger { get; set; }

        /// <summary>
        /// Gets or sets the default API resolver used by the E01D framework.
        /// </summary>
        public static ApiResolverApi_I ApiResolver { get; set; }

        public static ObjectFactoryApi_I ObjectFactory { get; set; } = new ObjectFactoryApi();

        public static X _ => Static;

        public static X Static { get; set; } = new X();

        /// <summary>
        /// Provides a default ToString implementation for classes that choose to override the default .NET method
        /// </summary>
        /// <param name="this"></param>
        /// <returns></returns>
        public static string ConvertToString(object @this)
        {
            return @this?.GetType().FullName ?? string.Empty;
        }

        public static T Create<T>() where T : new()
        {
            if (ObjectFactory == null)
            {
                throw new System.Exception("Factory missing exception");
            }

            return ObjectFactory.Create<T>();
        }

        /// <summary>
        /// Converts an exception to a string message.
        /// </summary>
        /// <param name="exception"></param>
        /// <param name="getInnerException"></param>
        /// <returns></returns>
        public static string GetExceptionMessage(System.Exception exception, bool getInnerException)
        {
            var message = exception.Message;

            if (!getInnerException || exception.InnerException == null) return message;

            var innerExceptionMessage = GetExceptionMessage(exception.InnerException, true);

            message += $"\tInner Exception: {innerExceptionMessage}";

            return message;
        }

        public static void InitializeNetworkFor46()
        {
            AppContext.SetSwitch(DisableCachingName, true);
            AppContext.SetSwitch(DontEnableSchUseStrongCryptoName, true);
        }

        /// <summary>
        /// Logs a critical exception to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        /// <param name="exception"></param>
        /// <returns></returns>
        public static LogEntry_I LogCritical(System.Exception exception)
        {
            try
            {
                return Logger?.LogCritical(exception);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a critical exception to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogCritical(System.Exception exception, string message)
        {
            try
            {
                return Logger?.LogCritical(exception);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs an exception to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogException(System.Exception exception)
        {
            try
            {
                return Logger?.LogException(exception);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs an exception to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogException(System.Exception exception, string message)
        {
            try
            {
                return Logger?.LogException(exception);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs an error to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogError(string message)
        {
            try
            {
                return Logger?.LogError(message);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a warning to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static LogEntry_I LogWarning(string message)
        {
            try
            {
                return Logger?.LogWarning(message);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a info to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogInfo(string message)
        {
            try
            {
                return Logger?.LogInfo(message);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a trace to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogTrace(string message)
        {
            try
            {
                return Logger?.LogTrace(message);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a debug to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogDebug(object message)
        {
            try
            {
                return Logger?.LogDebug(message);
            }
            catch
            {
                return null;
            }
        }

        /// <summary>
        /// Logs a debug to the configured logger.  If an exception occurs, null is returned.
        /// </summary>
        public static LogEntry_I LogDebug(string message)
        {
            try
            {
                return Logger?.LogDebug(message);
            }
            catch
            {
                return null;
            }
        }

        public static DateTime NowUtc()
        {
            return System.DateTime.UtcNow;
        }

        /// <summary>
        /// Attempts to resolve an API.
        /// </summary>
        /// <typeparam name="TApi">Gets or sets the type of the api to resolve.</typeparam>
        /// <returns>Returns an API if the API is successfully resolved.</returns>
        public static TApi ResolveApi<TApi>()
        {
            if (ApiResolver != null) return ApiResolver.GetApi<TApi>();

            throw new System.Exception("The functionality being accessed requires the use of an api resolver.  No api resolver has been configured.  The functionality cannot be located or accessed.");
        }

        /// <summary>
        /// Attempts to resolve an API.
        /// </summary>
        /// <returns>Returns an API if the API is successfully resolved.</returns>
        public static object ResolveApi(System.Type type)
        {
            if (ApiResolver != null) return ApiResolver.GetApi(type);

            throw new System.Exception("The functionality being accessed requires the use of an api resolver.  No api resolver has been configured.  The functionality cannot be located or accessed.");
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="iMilliseconds"></param>
        /// <returns>Returns true so it can be used easily in a while loop logic.</returns>
        public static bool Sleep(int iMilliseconds)
        {
            System.Threading.Thread.Sleep(iMilliseconds);

            return true;
        }

        
    }
}
