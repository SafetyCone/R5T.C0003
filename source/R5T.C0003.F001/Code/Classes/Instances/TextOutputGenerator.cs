using System;


namespace R5T.C0003.F001
{
	public class TextOutputGenerator : ITextOutputGenerator
	{
		#region Infrastructure

	    public static ITextOutputGenerator Instance { get; } = new TextOutputGenerator();

	    private TextOutputGenerator()
	    {
        }

	    #endregion
	}
}