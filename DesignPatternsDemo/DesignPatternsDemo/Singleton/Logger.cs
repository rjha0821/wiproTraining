using System;

namespace DesignPatternsDemo
{
    public sealed class Logger
    {
        private static Logger? _instance;
        private static readonly object _lock = new object();

        private Logger() { } // Private constructor to prevent instantiation

        public static Logger GetInstance()
        {
            if (_instance == null)
            {
                lock (_lock) // Thread safety
                {
                    if (_instance == null)
                        _instance = new Logger();
                }
            }
            return _instance;
        }

        public void Log(string message)
        {
            Console.WriteLine($"[LOG]: {message}");
        }
    }
}
