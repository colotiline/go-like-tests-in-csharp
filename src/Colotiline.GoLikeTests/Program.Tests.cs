using Xunit.Runner.InProc.SystemConsole;

namespace Colotiline.GoLikeTests;

public sealed class ProgramTests
{
    public static int Main(string[] args)
    {
        return ConsoleRunner.Run(args).GetAwaiter().GetResult();
    }
}