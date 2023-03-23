using System;

using R5T.T0131;


namespace R5T.C0003
{
	[ValuesMarker]
	public partial interface ITreeViewNodeNames : IValuesMarker
	{
		public string AddClassToProjectNode => "AddClassToProjectNode";
		public string AddInterfaceToProjectNode => "AddInterfaceToProjectNode";
		public string AddInstancesProjectNode => "AddInstancesProjectNode";
		public string AddInstanceProjectNode => "AddInstanceProjectNode";
        public string AddMissingDependenciesSolutionNode => "AddMissingDependenciesSolutionNode";
		public string AddProjectDependencyProjectNode => "AddProjectDependencyProjectNode";
        public string AddRazorComponentProjectNode => "AddRazorComponentProjectNode";
        public string AddServiceDefinitionToProjectNode => "AddServiceDefinitionToProjectNode";
		public string AddStronglyTypedTypeNode => "AddStronglyTypedTypeNode";
		public string AddWinFormProjectNode => "AddWinFormProjectNode";
        public string CodeOperationsNode => "CodeOperationsNode";
		public string CreateLibraryRepositoryNode => "CreateLibraryRepositoryNode";
		public string CreateS3BucketNode => "CreateS3BucketNode";
        public string GenerateS3BucketNameOperation => "GenerateS3BucketNameOperation";
		public string GenerateTailwindCssAllContentPathsFile => "GenerateTailwindCssAllContentPathsFile";
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
		public string NewWebStaticRazorComponents => "NewWebStaticRazorComponents";
		public string NewWinFormsApplicationRepositoryNode => "NewWinFormsApplicationRepositoryNode";
        public string OpenCodeElementScriptsSolution => "OpenCodeElementScriptsSolution";
        public string OpenCodeFileScriptsSolution => "OpenCodeFileScriptsSolution";
        public string OpenProjectFileScriptsSolution => "OpenProjectFileScriptsSolution";
        public string OpenProjectScriptsSolution => "OpenProjectScriptsSolution";
        public string OpenRepositoryScriptsSolution => "OpenRepositoryScriptsSolution";
        public string OpenSolutionFileScriptsSolution => "OpenSolutionFileScriptsSolution";
        public string OpenSolutionScriptsSolution => "OpenSolutionScriptsSolution";
        public string ProjectOperationsNode => "ProjectOperationsNode";
		public string RemoveExtraneousDependenciesSolutionNode => "RemoveExtraneousDependenciesSolutionNode";
		public string RemoveExtraneousProjectReferencesNode => "RemoveExtraneousProjectReferencesNode";
		public string RepositoryExistsNode => "RepositoryExistsNode";
		public string RepositoryOperationsNode => "RepositoryOperationsNode";
		public string S3OperationsNode => "S3OperationsNode";
        public string SolutionOperationsNode => "SolutionOperationsNode";
		public string UpdateAddXMethodsProjectNode => "UpdateAddXMethodsProjectNode";
		public string UpdateAddXMethodsSolutionNode => "UpdateAddXMethodsSolutionNode";
		public string UpdateToVs2022SolutionNode => "UpdateToVs2022SolutionNode";

    }
}