﻿using System;
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
    public sealed partial class NewLibrary : LayoutForCreateNewRepositoryOperation
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

                this.SetRemoteRepositoryUrl(repositoryLocations.RemoteUrl);
                this.SetLocalRepositoryDirectoryPath(repositoryLocations.LocalDirectoryPath);

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
