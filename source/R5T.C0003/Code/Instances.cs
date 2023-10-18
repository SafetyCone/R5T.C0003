using System;


namespace R5T.C0003
{
    public static class Instances
    {
        public static F0068.ICodeFileOperations CodeFileOperations => F0068.CodeFileOperations.Instance;
        public static F0000.IFileOperator FileOperator => F0000.FileOperator.Instance;
        public static IFilePaths FilePaths => C0003.FilePaths.Instance;
        public static F0000.IFileSystemOperator FileSystemOperator => F0000.FileSystemOperator.Instance;
        public static F0041.IGitHubOperator GitHubOperator => F0041.GitHubOperator.Instance;
        public static F0047.IGitHubOwnerNames GitHubOwnerNames => F0047.GitHubOwnerNames.Instance;
        public static F0047.IGitHubOwnerOperator GitHubOwnerOperator => F0047.GitHubOwnerOperator.Instance;
        public static F0047.IGitHubOwners GitHubOwners => F0047.GitHubOwners.Instance;
        public static ILogFilePathOperator LogFilePathOperator => C0003.LogFilePathOperator.Instance;
        public static F0033.INotepadPlusPlusOperator NotepadPlusPlusOperator => F0033.NotepadPlusPlusOperator.Instance;
        public static IOperations Operations => C0003.Operations.Instance;
        public static F0020.IProjectFileOperator ProjectFileOperator => F0020.ProjectFileOperator.Instance;
        public static IProjectOperations ProjectOperations => C0003.ProjectOperations.Instance;
        public static F0016.IProjectReferencesOperator ProjectReferencesOperator => F0016.ProjectReferencesOperator.Instance;
        public static IRepositoryOperations RepositoryOperations => C0003.RepositoryOperations.Instance;
        public static F0042.IRepositoryOperator RepositoryOperator => F0042.RepositoryOperator.Instance;
        public static F0063.ISolutionFileOperator SolutionFileOperator => F0063.SolutionFileOperator.Instance;
        public static F0085.ISolutionFileOperations SolutionFileOperations => F0085.SolutionFileOperations.Instance;
        public static Z0018.ISolutionFilePaths SolutionFilePaths => Z0018.SolutionFilePaths.Instance;
        public static ISolutionOperations SolutionOperations => C0003.SolutionOperations.Instance;
        public static F001.ITextOutputGenerator TextOutputGenerator => F001.TextOutputGenerator.Instance;
        public static ITreeViewNodeNames TreeViewNodeNames => C0003.TreeViewNodeNames.Instance;
        public static ITryOperator TryOperator => C0003.TryOperator.Instance;
        public static F0088.IVisualStudioOperator VisualStudioOperator => F0088.VisualStudioOperator.Instance;
        public static F0034.IWindowsExplorerOperator WindowsExplorerOperator => F0034.WindowsExplorerOperator.Instance;
    }
}