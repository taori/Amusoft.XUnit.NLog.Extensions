using Xunit;
using Xunit.Abstractions;

namespace Amusoft.XUnit.NLog.Extensions
{
	public class LoggedTestBase
	{
		public LoggedTestBase(ITestOutputHelper outputHelper)
		{
			XUnitOutputTarget.OutputHelper = outputHelper;
		}
	}
}