using NUnit.Framework;
using Microsoft.Extensions.Logging;
using Moq;
using System;

namespace Tests
{
    [TestFixture]
    public class LoggerExtraExtensionsTests
    {
        [Test, AutoMoqData]
        public void Test(ILogger logger, string message)
        {
            LoggerExtraExtensions.LogTrace(logger, message);
            
            Mock.Get(logger).Verify(p => p.Log(LogLevel.Trace, It.IsAny<EventId>(), message, null, It.IsAny<Func<string, Exception, string>>()));
        }
    }
}