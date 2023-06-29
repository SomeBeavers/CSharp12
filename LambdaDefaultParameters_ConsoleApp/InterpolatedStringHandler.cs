using System.Runtime.CompilerServices;

namespace LambdaDefaultParameters_ConsoleApp;

public class InterpolatedStringHandler1
{
    // The handler that will actually "build" the interpolated string"
    [InterpolatedStringHandler]
    public ref struct TraceLoggerParamsInterpolatedStringHandler
    {
        public TraceLoggerParamsInterpolatedStringHandler(int      literalLength, int formattedCount, Logger logger,
                                                          out bool handlerIsValid)
        {
            handlerIsValid = true;
            return;
        }

        public bool AppendLiteral(string s)
        {
            // Store and format part as required
            return true;
        }

        public bool AppendFormatted<T>(T t)
        {
            // Store and format part as required
            return true;
        }
    }

    // The logger class. The user has an instance of this, accesses it via static state, or some other access
    // mechanism
    public class Logger
    {

        public void LogTrace([InterpolatedStringHandlerArgument("")] TraceLoggerParamsInterpolatedStringHandler handler)
        {
            // Impl of logging
        }
    }

    void Test(Logger logger)
    {

        // Given the above definitions, usage looks like this:
        var name = "Fred Silberberg";
        var s = $"{name} will never be printed because info is < trace!";
        logger.LogTrace($"{name} will never be printed because info is < trace!");

        string originalString = "Hello, World!";
        var s2 = "hello"u8;                // Okay and type is ReadOnlySpan<byte>
        //var lambda = (ReadOnlySpan<byte> s3 = "hello"u8) => { };
    }
}


