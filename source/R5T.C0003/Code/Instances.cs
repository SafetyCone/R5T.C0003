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
        public static ICodeFileOperations CodeFileOperations { get; } = F0068.CodeFileOperations.Instance;
        public static IFileOperator FileOperator { get; } = F0000.FileOperator.Instance;
        public static IFilePaths FilePaths { get; } = C0003.FilePaths.Instance;
        public static IFileSystemOperator FileSystemOperator { get; } = F0000.FileSystemOperator.Instance;
        public static IGitHubOperator GitHubOperator { get; } = F0041.GitHubOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = F0047.GitHubOwners.Instance;
        public static ILogFilePathOperator LogFilePathOperator { get; } = C0003.LogFilePathOperator.Instance;
        public static INotepadPlusPlusOperator NotepadPlusPlusOperator { get; } = F0033.NotepadPlusPlusOperator.Instance;
        public static IOperations Operations { get; } = C0003.Operations.Instance;
        public static IProjectFileOperator ProjectFileOperator { get; } = F0020.ProjectFileOperator.Instance;
        public static IProjectOperations ProjectOperations { get; } = C0003.ProjectOperations.Instance;
        public static IProjectReferencesOperator ProjectReferencesOperator { get; } = F0016.ProjectReferencesOperator.Instance;
        public static IRepositoryOperations RepositoryOperations { get; } = C0003.RepositoryOperations.Instance;
        public static F0042.IRepositoryOperator RepositoryOperator { get; } = F0042.RepositoryOperator.Instance;
        public static F0063.ISolutionFileOperator SolutionFileOperator { get; } = F0063.SolutionFileOperator.Instance;
        public static ISolutionOperations SolutionOperations { get; } = C0003.SolutionOperations.Instance;
        public static ITextOutputGenerator TextOutputGenerator { get; } = F001.TextOutputGenerator.Instance;
        public static ITreeViewNodeNames TreeViewNodeNames { get; } = C0003.TreeViewNodeNames.Instance;
    }
}