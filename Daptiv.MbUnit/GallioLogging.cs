using System;
using Gallio.Runtime;
using Gallio.Runtime.Logging;

namespace Daptiv.MbUnit
{
	public static class GallioLogging
	{
		public static void LogInfo(string message)
		{
			try
			{
				string messageToLog = String.Format("[{0:H:mm:ss fff}] ", DateTime.Now) + message;
				RuntimeAccessor.Logger.Log(LogSeverity.Important,messageToLog);
				Console.WriteLine(messageToLog);
			}
			catch
			{
				// Logging should never throw.
			}
		}
	}
}