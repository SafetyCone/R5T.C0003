using System;
using System.Collections.Generic;
using System.Linq;

using R5T.T0132;


namespace R5T.C0003.F001
{
    [FunctionalityMarker]
	public partial interface ITextOutputGenerator : IFunctionalityMarker
	{
		public IEnumerable<string> ForDependencyChains(
			string rootProjectFilePath,
			string dependencyProjectFilePath,
			string[][] dependencyChains_Inclusive)
        {
			var lines = F0000.EnumerableOperator.Instance.From($"For dependency project:\n{dependencyProjectFilePath}\n")
				.Append($"Within root project:\n{rootProjectFilePath}\n")
				.Append(dependencyChains_Inclusive
					.SelectMany(projects => projects
						// Skip the first since it will be the root project.
						.Skip_First()
						.Append(String.Empty)))
				;

			return lines;
		}

		public IEnumerable<string> ForSolutionListDependencies(
			string solutionFilePath,
			string[] projectFilePaths,
			string projectFilePathsDescription)
        {
			var projectFilePathsCount = projectFilePaths.Length;

			var alphabeticalprojectFilePaths = projectFilePaths.OrderAlphabetically();

			var lines = Instances.EnumerableOperator.From($"For solution:\n\n\t{solutionFilePath}\n")
				.Append($"({projectFilePathsCount}) - {projectFilePathsDescription}:\n")
				.Append(alphabeticalprojectFilePaths)
				;

			return lines;
		}

		public IEnumerable<string> GetAllRecursiveSolutionProjectReferencesOutputLines(
			string solutionFilePath,
			string[] allRecursiveSolutionProjectReferences)
        {
			return this.ForSolutionListDependencies(
				solutionFilePath,
				allRecursiveSolutionProjectReferences,
				"All recursive project references");
		}

		public IEnumerable<string> GetMissingDependenciesOutputLines(
			string solutionFilePath,
			string[] allRecursiveSolutionProjectReferences)
		{
			return this.ForSolutionListDependencies(
				solutionFilePath,
				allRecursiveSolutionProjectReferences,
				"Project reference dependencies missing from solution");
		}
	}
}