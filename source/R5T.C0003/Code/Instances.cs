using System;

using R5T.F0041;
using R5T.F0042;
using R5T.F0045;
using R5T.F0047;


namespace R5T.C0003
{
    public static class Instances
    {
        public static IFilePaths FilePaths { get; } = C0003.FilePaths.Instance;
        public static IGitHubOperator GitHubOperator { get; } = F0041.GitHubOperator.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = F0047.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = F0047.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = F0047.GitHubOwners.Instance;
        public static IRepositoryOperations RepositoryOperations { get; } = F0045.RepositoryOperations.Instance;
        public static F0042.IRepositoryOperator RepositoryOperator { get; } = F0042.RepositoryOperator.Instance;
    }
}