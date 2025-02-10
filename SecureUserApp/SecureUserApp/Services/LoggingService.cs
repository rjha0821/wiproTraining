using System;
using Serilog;

public class LoggingService
{
    private static readonly ILogger logger = new LoggerConfiguration()
        .WriteTo.File("logs/app.log", rollingInterval: RollingInterval.Day)
        .CreateLogger();

    public static void LogInfo(string message)
    {
        logger.Information(message);
    }

    public static void LogError(string message)
    {
        logger.Error(message);
    }
}
