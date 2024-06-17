using System;
using System.Threading.Tasks;

using R5T.T0132;


namespace R5T.C0003.Deploy
{
    [FunctionalityMarker]
    public partial interface IDeployScripts : IFunctionalityMarker
    {
        /// <summary>
        /// Deploys a project by publishing it a destination directory. (This will build the project.)
        /// The project is selected by name among the sibling projects of this deploy project.
        /// The destination directory is a Dropbox directory (<inheritdoc cref="Z0024.IDirectoryPaths.LocalCloudBinariesDirectoryPath" path="descendant::value"/>).
        /// The destination directory will be named, and timestamped, with a current directory as well.
        /// </summary>
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

            Instances.WindowsExplorerOperator.Open(currentBinariesDirectoryPath);
        }
    }
}
