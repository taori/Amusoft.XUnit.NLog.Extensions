using NLog;
using NLog.Targets;
using Xunit.Abstractions;

namespace Amusoft.XUnit.NLog.Extensions
{
	[Target("XUnitOutputTarget")]
	public class XUnitOutputTarget : TargetWithLayout
	{
		protected override void Write(LogEventInfo logEvent)
		{
			OutputHelper.WriteLine(RenderLogEvent(Layout, logEvent));
		}

		public static ITestOutputHelper OutputHelper { get; set; }
	}
}