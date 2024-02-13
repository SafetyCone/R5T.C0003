using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface IOperations : IFunctionalityMarker,
		F0061.IOperations,
		F0102.IOperations
	{
        public void OpenCodeElementsScriptsSolution()
		{
			throw new NotImplementedException();

			//Instances.VisualStudioOperator.OpenSolutionFile(
			//	Instances.SolutionFilePaths.CodeElementScripts);
		}

		public void OpenCodeFileScriptsSolution()
		{
			Instances.VisualStudioOperator.Open_SolutionFile(
				Instances.SolutionFilePaths.CodeFileScripts);
		}

        public void OpenProjectFileScriptsSolution()
        {
            Instances.VisualStudioOperator.Open_SolutionFile(
                Instances.SolutionFilePaths.ProjectFileScripts);
        }

        public void OpenProjectScriptsSolution()
        {
            Instances.VisualStudioOperator.Open_SolutionFile(
                Instances.SolutionFilePaths.ProjectScripts);
        }

        public void OpenRepositoryScriptsSolution()
        {
            Instances.VisualStudioOperator.Open_SolutionFile(
                Instances.SolutionFilePaths.RepositoryScripts);
        }

        public void OpenSolutionFileScriptsSolution()
        {
            Instances.VisualStudioOperator.Open_SolutionFile(
                Instances.SolutionFilePaths.SolutionFileScripts);
        }

        public void OpenSolutionScriptsSolution()
        {
            Instances.VisualStudioOperator.Open_SolutionFile(
                Instances.SolutionFilePaths.SolutionScripts);
        }
    }
}
