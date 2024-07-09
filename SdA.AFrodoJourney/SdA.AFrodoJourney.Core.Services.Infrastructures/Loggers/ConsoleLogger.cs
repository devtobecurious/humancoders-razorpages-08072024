using SdA.AFrodoJourney.Core.Interfaces.Loggers;

namespace SdA.AFrodoJourney.Core.Services.Infrastructures.Loggers
{
	public class ConsoleLogger : ILogger
	{
		public void Log(string message)
		{
			Console.WriteLine(message);
		}
	}
}
