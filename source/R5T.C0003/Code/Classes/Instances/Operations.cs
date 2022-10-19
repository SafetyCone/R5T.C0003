using System;


namespace R5T.C0003
{
	public class Operations : IOperations
	{
		#region Infrastructure

	    public static IOperations Instance { get; } = new Operations();

	    private Operations()
	    {
        }

	    #endregion
	}
}