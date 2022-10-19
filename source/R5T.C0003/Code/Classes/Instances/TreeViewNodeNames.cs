using System;


namespace R5T.C0003
{
	public class TreeViewNodeNames : ITreeViewNodeNames
	{
		#region Infrastructure

	    public static ITreeViewNodeNames Instance { get; } = new TreeViewNodeNames();

	    private TreeViewNodeNames()
	    {
        }

	    #endregion
	}
}