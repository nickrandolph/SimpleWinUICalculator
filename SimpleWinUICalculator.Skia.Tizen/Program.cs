using Tizen.Applications;
using Uno.UI.Runtime.Skia;

namespace SimpleWinUICalculator.Skia.Tizen
{
	class Program
{
	static void Main(string[] args)
	{
		var host = new TizenHost(() => new SimpleWinUICalculator.App(), args);
		host.Run();
	}
}
}
