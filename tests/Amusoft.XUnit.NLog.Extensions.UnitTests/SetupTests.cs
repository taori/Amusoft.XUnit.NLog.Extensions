
using NLog;
using Xunit;
using Xunit.Abstractions;
using NLog = NLog;
using Logger = NLog.Logger;
using LogManager = NLog.LogManager;

namespace Amusoft.XUnit.NLog.Extensions.UnitTests
{
    public class SetupTests : LoggedTestBase
    {
	    private static readonly Logger Log = LogManager.GetLogger(nameof(SetupTests));

        [Fact]
        public void VerifyCompilesAndRuns()
        {
            Log.Debug("This message should be logged");
        }

        public SetupTests(ITestOutputHelper outputHelper) : base(outputHelper)
        {
        }
    }
}
