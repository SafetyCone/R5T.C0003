using System;


namespace R5T.C0003
{
	public class FilePaths : IFilePaths
	{
		#region Infrastructure

	    public static IFilePaths Instance { get; } = new FilePaths();

	    private FilePaths()
	    {
        }

	    #endregion
	}
}