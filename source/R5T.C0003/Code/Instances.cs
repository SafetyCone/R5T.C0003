using System;

using R5T.F0042;
using R5T.S0043.Library;


namespace R5T.C0003
{
    public static class Instances
    {
        public static IFilePaths FilePaths { get; } = C0003.FilePaths.Instance;
        public static IGitHubOwnerNames GitHubOwnerNames { get; } = S0043.Library.GitHubOwnerNames.Instance;
        public static IGitHubOwnerOperator GitHubOwnerOperator { get; } = S0043.Library.GitHubOwnerOperator.Instance;
        public static IGitHubOwners GitHubOwners { get; } = S0043.Library.GitHubOwners.Instance;
        public static IRepositoryOperator RepositoryOperator { get; } = F0042.RepositoryOperator.Instance;
    }
}