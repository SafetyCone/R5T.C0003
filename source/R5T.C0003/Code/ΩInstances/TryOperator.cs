using System;


namespace R5T.C0003
{
	public class TryOperator : ITryOperator
	{
		#region Infrastructure

	    public static ITryOperator Instance { get; } = new TryOperator();

	    private TryOperator()
	    {
        }

	    #endregion
	}
}