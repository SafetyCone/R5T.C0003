using System;

using R5T.T0131;


namespace R5T.C0003
{
	[ValuesMarker]
	public partial interface IFilePaths : IValuesMarker
	{
		public string LogFilePath => @"C:\Temp\Log.txt";
	}
}