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

using R5T.F0000;
using R5T.F0034;


namespace R5T.C0003.Forms.Repository
{
    public partial class LayoutForCreateNewRepositoryOperation : LayoutForRepositoryOperation
    {
        public LayoutForCreateNewRepositoryOperation()
        {
            InitializeComponent();
        }

        protected string GetDescription()
        {
            var description = this.DescriptionTextBox.Text;
            return description;
        }

        protected bool GetIsPrivate()
        {
            var output = this.IsPrivateCheckBox.Checked;
            return output;
        }

        private void RemoteRepositoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = this.RemoteRepositoryLinkLabel.Text;

            UrlOperator.Instance.OpenInBrowser(url);
        }

        private void LocalRepositoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var path = this.LocalRepositoryLinkLabel.Text;

            WindowsExplorerOperator.Instance.OpenDirectoryInExplorer(path);
        }

        protected void SetRemoteRepositoryUrl(string remoteRepositoryUrl)
        {
            this.RemoteRepositoryLinkLabel.Text = remoteRepositoryUrl;
        }

        protected void SetLocalRepositoryDirectoryPath(string localRepositoryDirectoryPath)
        {
            this.LocalRepositoryLinkLabel.Text = localRepositoryDirectoryPath;
        }
    }
}
