using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.Logging;


namespace R5T.C0003.Forms.Repository
{
    public partial class NewLibrary : LayoutForRepositoryOperation
    {
        private ILogger Logger { get; }


        public NewLibrary(
            ILogger<NewLibrary> logger)
        {
            InitializeComponent();

            this.Logger = logger;
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            var repositoryName = this.GetRepositoryName();
            var gitHubOwner = this.GetGitHubOwner();
            var description = this.GetDescription();
            var isPrivate = this.GetIsPrivate();

            try
            {
                var repositoryLocations = await Instances.RepositoryOperations.CreateNew_LibraryRepository(
                    gitHubOwner,
                    repositoryName,
                    description,
                    isPrivate,
                    this.Logger);

                
                this.RemoteRepositoryLinkLabel.Text = repositoryLocations.RemoteUrl;
                this.LocalRepositoryLinkLabel.Text = repositoryLocations.LocalDirectoryPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string GetDescription()
        {
            var description = this.DescriptionTextBox.Text;
            return description;
        }

        private bool GetIsPrivate()
        {
            var output = this.IsPrivateCheckBox.Checked;
            return output;
        }

        private void RemoteRepositoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = this.RemoteRepositoryLinkLabel.Text;

            F0000.UrlOperator.Instance.OpenInBrowser(url);
        }

        private void LocalRepositoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var path = this.LocalRepositoryLinkLabel.Text;

            F0034.WindowsExplorerOperator.Instance.OpenDirectoryInExplorer(path);
        }
    }
}
