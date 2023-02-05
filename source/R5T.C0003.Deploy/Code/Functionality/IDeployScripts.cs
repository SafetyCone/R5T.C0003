using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003.Deploy
{
    [FunctionalityMarker]
    public partial interface IDeployScripts : IFunctionalityMarker
    {
        public async Task DeployToLocalCloudBinariesDirectory()
        {
            /// Inputs.
            var targetProjectName = "R5T.C0003";
            var localCloudBinariesDirectoryPath = Instances.DirectoryPaths.LocalCloudBinariesDirectoryPath;


            /// Run.
            var targetProjectFilePath = Instances.ProjectPathConventions.GetExecutableSiblingProjectFilePath(targetProjectName);

            var currentBinariesDirectoryPath = await Instances.LoggingOperator.InConsoleLoggerContext(
                nameof(DeployToLocalCloudBinariesDirectory),
                async logger =>
                {
                    var currentBinariesDirectoryPath = await Instances.PublicationOperator.Publish(
                        targetProjectFilePath,
                        localCloudBinariesDirectoryPath,
                        logger);

                    return currentBinariesDirectoryPath;
                });

            Instances.WindowsExplorerOperator.OpenDirectoryInExplorer(currentBinariesDirectoryPath);
        }
    }
}
