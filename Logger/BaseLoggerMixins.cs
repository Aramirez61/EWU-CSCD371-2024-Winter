﻿namespace Logger;

public static class BaseLoggerMixins
{
    public static void Error(this BaseLogger baseLogger, string message, params object[] arguments)
    {
        if (baseLogger == null)
        {
            throw new System.ArgumentNullException(nameof(baseLogger));
        }
        else
        {
            baseLogger.Log(LogLevel.Error, string.Format(message, arguments));
        }
    }

    public static void Warning(this BaseLogger baseLogger, string message, params object[] arguments)
    {
        if (baseLogger == null)
        {
            throw new System.ArgumentNullException(nameof(baseLogger));
        }
        else
        {
            baseLogger.Log(LogLevel.Warning, string.Format(message, arguments));
        }
    }

    public static void Information(this BaseLogger baseLogger, string message, params object[] arguments)
    {
        if (baseLogger == null)
        {
            throw new System.ArgumentNullException(nameof(baseLogger));
        }
        else
        {
            baseLogger.Log(LogLevel.Information, string.Format(message, arguments));
        }
    }

    public static void Debug(this BaseLogger baseLogger, string message, params object[] arguments)
    {
        if (baseLogger == null)
        {
            throw new System.ArgumentNullException(nameof(baseLogger));
        }
        else
        {
            baseLogger.Log(LogLevel.Debug, string.Format(message, arguments));
        }
    }
}