// ReSharper disable CheckNamespace
// ReSharper disable TemplateIsNotCompileTimeConstantProblem

namespace Microsoft.Extensions.Logging;

public static class TypedLoggerExtensions
{
	public static void LogTrace(this ILogger logger, string message) => Log(logger, LogLevel.Trace, message);

	public static void LogTrace<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Trace, message, arg0);

	public static void LogTrace<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Trace, message, arg0, arg1);

	public static void LogTrace<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Trace, message, arg0, arg1, arg2);

	public static void LogTrace<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Trace, message, arg0, arg1, arg2, arg3);

	public static void LogDebug(this ILogger logger, string message) => Log(logger, LogLevel.Debug, message);

	public static void LogDebug<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Debug, message, arg0);

	public static void LogDebug<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Debug, message, arg0, arg1);

	public static void LogDebug<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Debug, message, arg0, arg1, arg2);

	public static void LogDebug<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Debug, message, arg0, arg1, arg2, arg3);

	public static void LogInformation(this ILogger logger, string message) => Log(logger, LogLevel.Information, message);

	public static void LogInformation<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Information, message, arg0);

	public static void LogInformation<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Information, message, arg0, arg1);

	public static void LogInformation<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Information, message, arg0, arg1, arg2);

	public static void LogInformation<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Information, message, arg0, arg1, arg2, arg3);

	public static void LogWarning(this ILogger logger, string message) => Log(logger, LogLevel.Warning, message);

	public static void LogWarning<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Warning, message, arg0);

	public static void LogWarning<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Warning, message, arg0, arg1);

	public static void LogWarning<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Warning, message, arg0, arg1, arg2);

	public static void LogWarning<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Warning, message, arg0, arg1, arg2, arg3);

	public static void LogError(this ILogger logger, string message) => Log(logger, LogLevel.Error, message);

	public static void LogError<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Error, message, arg0);

	public static void LogError<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Error, message, arg0, arg1);

	public static void LogError<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Error, message, arg0, arg1, arg2);

	public static void LogError<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Error, message, arg0, arg1, arg2, arg3);

	public static void LogCritical(this ILogger logger, string message) => Log(logger, LogLevel.Critical, message);

	public static void LogCritical<T0>(this ILogger logger, string message, T0 arg0) => Log(logger, LogLevel.Critical, message, arg0);

	public static void LogCritical<T0, T1>(this ILogger logger, string message, T0 arg0, T1 arg1) => Log(logger, LogLevel.Critical, message, arg0, arg1);

	public static void LogCritical<T0, T1, T2>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2) => Log(logger, LogLevel.Critical, message, arg0, arg1, arg2);

	public static void LogCritical<T0, T1, T2, T3>(this ILogger logger, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3) => Log(logger, LogLevel.Critical, message, arg0, arg1, arg2, arg3);

	private static void Log(ILogger logger, LogLevel logLevel, string message)
	{
		if (logger.IsEnabled(logLevel))
		{
			logger.Log(logLevel, message);
		}
	}

	private static void Log<T0>(ILogger logger, LogLevel logLevel, string message, T0 arg0)
	{
		if (logger.IsEnabled(logLevel))
		{
			logger.Log(logLevel, message, [arg0]);
		}
	}

	private static void Log<T0, T1>(ILogger logger, LogLevel logLevel, string message, T0 arg0, T1 arg1)
	{
		if (logger.IsEnabled(logLevel))
		{
			logger.Log(logLevel, message, [arg0, arg1]);
		}
	}

	private static void Log<T0, T1, T2>(ILogger logger, LogLevel logLevel, string message, T0 arg0, T1 arg1, T2 arg2)
	{
		if (logger.IsEnabled(logLevel))
		{
			logger.Log(logLevel, message, [arg0, arg1, arg2]);
		}
	}

	private static void Log<T0, T1, T2, T3>(ILogger logger, LogLevel logLevel, string message, T0 arg0, T1 arg1, T2 arg2, T3 arg3)
	{
		if (logger.IsEnabled(logLevel))
		{
			logger.Log(logLevel, message, [arg0, arg1, arg2, arg3]);
		}
	}
}
