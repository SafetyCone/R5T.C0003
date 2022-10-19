using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface ISolutionOperations : IFunctionalityMarker,
		F0063.ISolutionOperations
	{


		public async Task ListMissingDependencies(
			string solutionFilePath)
        {
			var missingDependencies = await this.GetMissingDependencies(solutionFilePath);

			var lines = Instances.TextOutputGenerator.GetMissingDependenciesOutputLines(
				solutionFilePath,
				missingDependencies);

			Instances.Operations.WriteLinesAndOpenInNotepadPlusPlus(
				lines);
		}

		public async Task ListAllRecursiveProjectReferences(
			string solutionFilePath)
        {
			var allRecursiveProjectReferences = await this.GetAllRecursiveProjectReferences(solutionFilePath);

			var lines = Instances.TextOutputGenerator.GetAllRecursiveSolutionProjectReferencesOutputLines(
				solutionFilePath,
				allRecursiveProjectReferences);

			Instances.Operations.WriteLinesAndOpenInNotepadPlusPlus(
				lines);
		}
	}
}