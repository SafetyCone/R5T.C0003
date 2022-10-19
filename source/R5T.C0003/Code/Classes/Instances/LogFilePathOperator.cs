using System;


namespace R5T.C0003
{
	public class LogFilePathOperator : ILogFilePathOperator
	{
		#region Infrastructure

	    public static ILogFilePathOperator Instance { get; } = new LogFilePathOperator();

	    private LogFilePathOperator()
	    {
        }

	    #endregion
	}
}