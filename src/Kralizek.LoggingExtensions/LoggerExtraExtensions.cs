using System;

// ReSharper disable CheckNamespace

namespace Microsoft.Extensions.Logging
{ 
    public static class LoggerExtraExtensions
    {
        private static void Log<TState>(this ILogger logger, LogLevel level, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            logger.Log(level, 0, state, exception, formatter);
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

        private static void Log(this ILogger logger, LogLevel level, Exception error)
        {
            var state = new { };

            Log(logger, level, state, error, (a, e) => e.ToString());
        }

        #region Trace

        public static void Trace(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Trace, message);
        }

        public static void Trace(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Trace, error);
        }

        public static void Trace<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Trace, state, formatter);
        }

        #endregion

        #region Debug

        public static void Debug(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Debug, message);
        }

        public static void Debug(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Debug, error);
        }

        public static void Debug<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Debug, state, formatter);
        }

        #endregion

        #region Debug

        public static void Information(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Information, message);
        }

        public static void Information(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Information, error);
        }

        public static void Information<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Information, state, formatter);
        }

        #endregion

        #region Warn

        public static void Warn(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Warning, message);
        }

        public static void Warn(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Warning, error);
        }

        public static void Warn<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Warning, state, formatter);
        }

        #endregion

        #region Error

        public static void Error(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Error, message);
        }

        public static void Error(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Error, error);
        }

        public static void Error<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Error, state, formatter);
        }

        #endregion

        #region Critical

        public static void Critical(this ILogger logger, string message)
        {
            Log(logger, LogLevel.Critical, message);
        }

        public static void Critical(this ILogger logger, Exception error)
        {
            Log(logger, LogLevel.Critical, error);
        }

        public static void Critical<TState>(this ILogger logger, TState state, Func<TState, string> formatter)
        {
            Log(logger, LogLevel.Critical, state, formatter);
        }

        #endregion

    }
}
