using System;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface ILogFilePathOperator : IFunctionalityMarker
	{
		public string GetLogFilePath()
        {
			var now = F0000.NowOperator.Instance.Get_Now_Local();

			var timestamp = F0000.DateTimeOperator.Instance.ToString_YYYYMMDD_HHMMSS(now);

			var applicationName = "R5T.C0003";

			var logFilePath = $@"C:\Temp\Logs\{applicationName}-{timestamp}.log";
			return logFilePath;
        }
	}
}