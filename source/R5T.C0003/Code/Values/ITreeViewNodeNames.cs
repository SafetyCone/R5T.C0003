using System;

using R5T.T0131;


namespace R5T.C0003
{
	[ValuesMarker]
	public partial interface ITreeViewNodeNames : IValuesMarker
	{
		public string AddMissingDependenciesSolutionNode => "AddMissingDependenciesSolutionNode";
		public string CodeOperationsNode => "CodeOperationsNode";
		public string CreateLibraryRepositoryNode => "CreateLibraryRepositoryNode";
		public string ListAllDependenciesSolutionNode => "ListAllDependenciesSolutionNode";
		public string ListMissingDependenciesSolutionNode => "ListMissingDependenciesSolutionNode";
		public string ListRecursiveDependenciesProjectNode => "ListRecursiveDependenciesProjectNode";
		public string NewConsoleRepositoryNode => "NewConsoleRepositoryNode";
		public string NewProgramAsServiceRepositoryNode => "NewProgramAsServiceRepositoryNode";
		public string NewWebApplicationRepositoryNode => "NewWebApplicationRepositoryNode";
		public string ProjectOperationsNode => "ProjectOperationsNode";
		public string RepositoryExistsNode => "RepositoryExistsNode";
		public string RepositoryOperationsNode => "RepositoryOperationsNode";
		public string SolutionOperationsNode => "SolutionOperationsNode";
	}
}