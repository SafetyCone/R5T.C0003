using System;

using R5T.T0142;


namespace R5T.C0003
{
    /// <summary>
    /// Use this interface to ensure that setup steps that should not be run as part of the designer, can be run later.
    /// For example, it is very important to keep *all* code that is not in a directly referenced project reference off the WinForms designer initialization path.
    /// (This is because the designer does not copy all recursive references to its temporary directory, only references directly referenced by the WinForms project.)
    /// </summary>
    [UtilityTypeMarker]
    public interface IHasNonWinFormsDesginerSetup
    {
        public void Setup();
    }
}
