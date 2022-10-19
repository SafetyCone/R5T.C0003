using System;
using System.Linq;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface IProjectOperations : IFunctionalityMarker
	{
        public async Task ListRecursiveProjectReferences_ToFile(
            string projectFilePath)
        {
            var projectReferenceFilePaths = await Instances.ProjectReferencesOperator.GetRecursiveProjectReferences(
                projectFilePath,
                Instances.ProjectFileOperator.GetDirectProjectReferenceFilePaths);

            var lines = F0000.EnumerableOperator.Instance.From($"For project:\n\n\t{projectFilePath}\n\nRecursive project reference dependencies of project:")
                .Append(String.Empty)
                .Append(projectReferenceFilePaths)
                ;

            Instances.FileOperator.WriteLines(
                Instances.FilePaths.OutputTextFilePath,
                lines);

            Instances.NotepadPlusPlusOperator.Open(
                Instances.FilePaths.OutputTextFilePath);
        }
    }
}