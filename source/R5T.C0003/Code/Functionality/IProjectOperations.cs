using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface IProjectOperations : IFunctionalityMarker
	{
        public void CreateServiceDefinition(
            string projectFilePath,
            string serviceDefinitionInterfaceTypeName)
        {
            // Create the service definition interface class file path.
            var projectPathsOperator = F0052.ProjectPathsOperator.Instance;

            var serviceDefinitionCodeFilePath = projectPathsOperator.GetServiceDefinitionFilePath(
                projectFilePath,
                serviceDefinitionInterfaceTypeName);

            // Get the namespace name.
            var namespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName(projectFilePath);

            // Create the service definition.
            F0000.FileSystemOperator.Instance.EnsureDirectoryForFilePathExists(
                serviceDefinitionCodeFilePath);

            F0053.CodeFileGenerator.Instance.CreateServiceDefinition(
                serviceDefinitionCodeFilePath,
                namespaceName,
                serviceDefinitionInterfaceTypeName);

            // Ensure the project has a project reference to the right projects.
            var projectReferenceFilePathsForServiceDefinition = new[]
            {
                @"C:\Code\DEV\Git\GitHub\SafetyCone\R5T.T0064\source\R5T.T0064\R5T.T0064.csproj",
            };

            F0020.ProjectFileOperator.Instance.AddProjectReferences_Idempotent_Synchronous(
                projectFilePath,
                projectReferenceFilePathsForServiceDefinition);
        }

        public async Task ListProjectDependencyChains_ToFile(
            string rootProjectFilePath,
            string dependencyProjectFilePath)
        {
            var dependencyChains_Inclusive = await Instances.ProjectReferencesOperator.GetDependencyChains_Inclusive(
                rootProjectFilePath,
                dependencyProjectFilePath,
                Instances.ProjectFileOperator.GetDirectProjectReferenceFilePaths);

            // Write output file.
            var lines = Instances.TextOutputGenerator.ForDependencyChains(
                rootProjectFilePath,
                dependencyProjectFilePath,
                dependencyChains_Inclusive);

            Instances.FileOperator.WriteLines_Synchronous(
                Instances.FilePaths.OutputTextFilePath,
                lines);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputTextFilePath);
        }

        public async Task ListRecursiveProjectReferences_ToFile(
            string projectFilePath)
        {
            var projectReferenceFilePaths = await Instances.ProjectReferencesOperator.GetRecursiveProjectReferences(
                projectFilePath,
                Instances.ProjectFileOperator.GetDirectProjectReferenceFilePaths);

            var lines = F0000.EnumerableOperator.Instance.From($"For project:\n\n\t{projectFilePath}\n\nRecursive project reference dependencies of project:")
                .Append(String.Empty)
                .Append(projectReferenceFilePaths
                    .OrderAlphabetically())
                ;

            Instances.FileOperator.WriteLines_Synchronous(
                Instances.FilePaths.OutputTextFilePath,
                lines);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputTextFilePath);
        }
    }
}