using System;
using System.Diagnostics;

namespace Root.Code.Framework.E01D
{
    public class Debug
    {
        public static bool IsAttached { get; }

        public static bool IsConsoleEnabled { get; set; }

        public static bool IsEnabled { get; set; }

        static Debug()
        {
            IsAttached = Debugger.IsAttached;

            IsEnabled = IsAttached;
        }

        public static void Assert(bool condition)
        {
            System.Diagnostics.Debug.Assert(condition);
        }

        public static void Assert(bool condition, string message)
        {
            System.Diagnostics.Debug.Assert(condition, message);
        }

        public static void WriteLine(string line)
        {
            if (!IsEnabled) return;

            X.LogDebug(line);

            System.Diagnostics.Debug.WriteLine(line);

            if (IsConsoleEnabled) // useful when writing test cases
            {
                Console.WriteLine(line);
            }
        }

        
    }
}
