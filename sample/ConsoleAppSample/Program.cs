using System;
using Microsoft.Extensions.Logging;

namespace ConsoleAppSample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loggerFactory = new LoggerFactory().AddConsole((s,l) => l >= LogLevel.Trace);

            var logger = loggerFactory.CreateLogger<Program>();



            LogState(logger, new {text = "Hello World", value = 42}, s => $"text: {s.text}; value: {s.value}");

            LogErrorWithState(logger, new { text = "Hello World", value = 42 }, (s,e) => e.ToString());
        }

        private static void LogState<TState>(ILogger logger, TState state, Func<TState, string> formatter)
        {
            logger.LogTrace(state, formatter);

            logger.LogDebug(state, formatter);

            logger.LogInformation(state, formatter);

            logger.LogWarning(state, formatter);

            logger.LogError(state, formatter);

            logger.LogCritical(state, formatter);
        }

        private static void LogErrorWithState<TState>(ILogger logger, TState state, Func<TState, Exception, string> formatter)
        {
            try
            {
                throw new Exception("Hello world");
            }
            catch (Exception ex)
            {
                logger.LogTrace(state, ex, formatter);

                logger.LogDebug(state, ex, formatter);

                logger.LogInformation(state, ex, formatter);

                logger.LogWarning(state, ex, formatter);

                logger.LogError(state, ex, formatter);

                logger.LogCritical(state, ex, formatter);
            }
        }
    }
}
