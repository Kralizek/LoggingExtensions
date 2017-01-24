using System;

// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.Logging
{ 
    public static class LoggerExtraExtensions
    {
        private static void Log<TState>(this ILogger logger, LogLevel level, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(level, 0, state, error, formatter);
        }

        private static void Log<TState>(this ILogger logger, LogLevel level, EventId eventId, TState state, Func<TState, string> formatter)
        {
            logger.Log(level, eventId, state, null, (s, _) => formatter(s));
        }

        private static void Log<TState>(this ILogger logger, LogLevel level, TState state, Func<TState, string> formatter)
        {
            Log(logger, level, state, null, (s, _) => formatter(s));
        }

        private static void Log(this ILogger logger, LogLevel level, string message)
        {
            var state = new { message };

            Log(logger, level, state, null, (s, _) => state.message);
        }

        private static readonly object EmptyState = new object();

        private static void Log(this ILogger logger, LogLevel level, Exception error)
        {
            Log(logger, level, EmptyState, error, (a, e) => e.ToString());
        }

        #region Trace

        public static void LogTrace(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Trace, message);
        }

        public static void LogTrace(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Trace, error);
        }

        public static void LogTrace<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Trace, state, formatter);
        }

        public static void LogTrace<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Trace, eventId, state, formatter);
        }

        public static void LogTrace<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Trace, eventId, state, error, formatter);
        }

        public static void LogTrace<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Trace, state, error, formatter);
        }

        #endregion

        #region Debug

        public static void LogDebug(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Debug, message);
        }

        public static void LogDebug(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Debug, error);
        }

        public static void LogDebug<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Debug, state, formatter);
        }

        public static void LogDebug<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Debug, eventId, state, formatter);
        }

        public static void LogDebug<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Debug, eventId, state, error, formatter);
        }

        public static void LogDebug<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Debug, state, error, formatter);
        }

        #endregion

        #region Information

        public static void LogInformation(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Information, message);
        }

        public static void LogInformation(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Information, error);
        }

        public static void LogInformation<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Information, state, formatter);
        }

        public static void LogInformation<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Information, eventId, state, formatter);
        }

        public static void LogInformation<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Information, eventId, state, error, formatter);
        }

        public static void LogInformation<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Information, state, error, formatter);
        }

        #endregion

        #region Warn

        public static void LogWarning(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Warning, message);
        }

        public static void LogWarning(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Warning, error);
        }

        public static void LogWarning<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Warning, state, formatter);
        }

        public static void LogWarning<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Warning, eventId, state, formatter);
        }

        public static void LogWarning<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Warning, eventId, state, error, formatter);
        }

        public static void LogWarning<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Warning, state, error, formatter);
        }

        #endregion

        #region Error

        public static void LogError(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Error, message);
        }

        public static void LogError(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Error, error);
        }

        public static void LogError<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Error, state, formatter);
        }

        public static void LogError<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Error, eventId, state, formatter);
        }

        public static void LogError<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Error, eventId, state, error, formatter);
        }

        public static void LogError<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Error, state, error, formatter);
        }

        #endregion

        #region Critical

        public static void LogCritical(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Critical, message);
        }

        public static void LogCritical(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Critical, error);
        }

        public static void LogCritical<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Critical, state, formatter);
        }

        public static void LogCritical<TState>(this ILogger logger, EventId eventId, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Critical, eventId, state, formatter);
        }

        public static void LogCritical<TState>(this ILogger logger, EventId eventId, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            logger.Log(LogLevel.Critical, eventId, state, error, formatter);
        }

        public static void LogCritical<TState>(this ILogger logger, TState state, Exception error, Func<TState, Exception, string> formatter)
        {
            Log(logger, LogLevel.Critical, state, error, formatter);
        }

        #endregion

    }
}
