using System;

using R5T.F0000;
using R5T.F0016;
using R5T.F0020;
using R5T.F0033;
using R5T.F0041;
using R5T.F0047;
using R5T.F0068;

using R5T.C0003.F001;


namespace R5T.C0003
{
    public static class Instances
    {
        public static ICodeFileOperations CodeFileOperations => F0068.CodeFileOperations.Instance;
        public static IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static IFilePaths FilePaths => C0003.FilePaths.Instance;
        public static IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames => F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator => F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners => F0047.GitHubOwners.Instance;
        public static ILogFilePathOperator LogFilePathOperator => C0003.LogFilePathOperator.Instance;
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IOperations Operations => C0003.Operations.Instance;
        public static IProjectFileOperator ProjectFileOperator => F0020.ProjectFileOperator.Instance;
        public static IProjectOperations ProjectOperations => C0003.ProjectOperations.Instance;
        public static IProjectReferencesOperator ProjectReferencesOperator => F0016.ProjectReferencesOperator.Instance;
        public static IRepositoryOperations RepositoryOperations => C0003.RepositoryOperations.Instance;
        public static F0042.IRepositoryOperator RepositoryOperator => F0042.RepositoryOperator.Instance;
        public static F0063.ISolutionFileOperator SolutionFileOperator => F0063.SolutionFileOperator.Instance;
        public static F0085.ISolutionFileOperations SolutionFileOperations => F0085.SolutionFileOperations.Instance;
        public static ISolutionOperations SolutionOperations => C0003.SolutionOperations.Instance;
        public static ITextOutputGenerator TextOutputGenerator => F001.TextOutputGenerator.Instance;
        public static ITreeViewNodeNames TreeViewNodeNames => C0003.TreeViewNodeNames.Instance;
    }
}