using NUnit.Framework;
using Microsoft.Extensions.Logging;
using Moq;
using System;

// ReSharper disable InvokeAsExtensionMethod

namespace Tests
{
    [TestFixture]
    public class LogTraceTests
    {
        private static Func<TState, Exception, string> AnyFormatter<TState>() => It.IsAny<Func<TState, Exception, string>>();

        private static void SetUpLogger<TState>(ILogger logger)
        {
            Mock.Get(logger)
                .Setup(p => p.Log(It.IsAny<LogLevel>(), It.IsAny<EventId>(), It.IsAny<TState>(), It.IsAny<Exception>(), It.IsAny<Func<TState, Exception, string>>()))
                .Callback<LogLevel, EventId, TState, Exception, Func<TState, Exception, string>>((l, ev, s, e, f) => f(s, e));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_message(ILogger logger, string message)
        {
            LoggerExtraExtensions.LogTrace(logger, message);
            
            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, 0, message, null, AnyFormatter<string>()));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_exception(ILogger logger, Exception error)
        {
            LoggerExtraExtensions.LogTrace(logger, error);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, 0, It.IsAny<object>(), error, AnyFormatter<object>()));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_state(ILogger logger, TestState state, Func<TestState, string> formatter)
        {
            SetUpLogger<TestState>(logger);

            LoggerExtraExtensions.LogTrace(logger, state, formatter);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, 0, state, null, AnyFormatter<TestState>()));

            Mock.Get(formatter).Verify(p => p(state));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_state_with_event(ILogger logger, TestState state, EventId eventId, Func<TestState, string> formatter)
        {
            SetUpLogger<TestState>(logger);

            LoggerExtraExtensions.LogTrace(logger, eventId, state, formatter);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, eventId, state, null, AnyFormatter<TestState>()));

            Mock.Get(formatter).Verify(p => p(state));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_state_with_error(ILogger logger, TestState state, Exception error, Func<TestState, Exception, string> formatter)
        {
            SetUpLogger<TestState>(logger);

            LoggerExtraExtensions.LogTrace(logger, state, error, formatter);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, 0, state, error, AnyFormatter<TestState>()));

            Mock.Get(formatter).Verify(p => p(state, error));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_state_with_error_and_event(ILogger logger, TestState state, EventId eventId, Exception error, Func<TestState, Exception, string> formatter)
        {
            SetUpLogger<TestState>(logger);

            LoggerExtraExtensions.LogTrace(logger, eventId, state, error, formatter);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, eventId, state, error, AnyFormatter<TestState>()));

            Mock.Get(formatter).Verify(p => p(state, error));
        }

        [Test, AutoMoqData]
        public void LogTrace_logs_state_with_error_and_event(ILogger logger, EventId eventId, Exception error)
        {
            LoggerExtraExtensions.LogTrace(logger, eventId, error);

            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, eventId, It.IsAny<object>(), error, AnyFormatter<object>()));
        }
    }
}