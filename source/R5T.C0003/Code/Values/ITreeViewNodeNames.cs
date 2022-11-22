using System;

using R5T.T0131;


namespace R5T.C0003
{
	[ValuesMarker]
	public partial interface ITreeViewNodeNames : IValuesMarker
	{
		public string AddMissingDependenciesSolutionNode => "AddMissingDependenciesSolutionNode";
		public string AddServiceDefinitionToProjectNode => "AddServiceDefinitionToProjectNode";
		public string AddStronglyTypedTypeNode => "AddStronglyTypedTypeNode";
        public string CodeOperationsNode => "CodeOperationsNode";
		public string CreateLibraryRepositoryNode => "CreateLibraryRepositoryNode";
		public string CreateS3BucketNode => "CreateS3BucketNode";
		public string GenerateS3BucketNameOperation => "GenerateS3BucketNameOperation";
		public string IdentifyExtraneousProjectReferencesNode => "IdentifyExtraneousProjectReferencesNode";
		public string ListAllDependenciesSolutionNode => "ListAllDependenciesSolutionNode";
		public string ListDependencyChainsProjectNode => "ListDependencyChainsProjectNode";
		public string ListMissingDependenciesSolutionNode => "ListMissingDependenciesSolutionNode";
		public string ListRecursiveDependenciesProjectNode => "ListRecursiveDependenciesProjectNode";
		public string MiscellaneousOperationsNode => "MiscellaneousOperationsNode";
		public string NewConsoleRepositoryNode => "NewConsoleRepositoryNode";
        public string NewGuidNode => "NewGuidNode";
        public string NewProgramAsServiceRepositoryNode => "NewProgramAsServiceRepositoryNode";
		public string NewRepositoryOnlyNode => "NewRepositoryOnlyNode";
		public string NewWebApplicationRepositoryNode => "NewWebApplicationRepositoryNode";
		public string ProjectOperationsNode => "ProjectOperationsNode";
		public string RemoveExtraneousDependenciesSolutionNode => "RemoveExtraneousDependenciesSolutionNode";
		public string RemoveExtraneousProjectReferencesNode => "RemoveExtraneousProjectReferencesNode";
		public string RepositoryExistsNode => "RepositoryExistsNode";
		public string RepositoryOperationsNode => "RepositoryOperationsNode";
		public string SolutionOperationsNode => "SolutionOperationsNode";
		public string UpdateAddXMethodsProjectNode => "UpdateAddXMethodsProjectNode";
		public string UpdateAddXMethodsSolutionNode => "UpdateAddXMethodsSolutionNode";
	}
}