using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms.Repository
{
    public sealed partial class RepositoryExists : LayoutForRepositoryOperation, IHasNonWinFormsDesginerSetup
    {
        public RepositoryExists()
        {
            InitializeComponent();
        }

        private async void CheckExistsButton_Click(object sender, EventArgs e)
        {
            var repositoryName = this.GetRepositoryName();
            var gitHubOwner = this.GetGitHubOwner();

            var repositoryExists = await Instances.RepositoryOperator.RepositoryExists(
                gitHubOwner,
                repositoryName);

            if(repositoryExists)
            {
                this.ResultLabel.Text = "Exists";
                this.ResultLabel.ForeColor = Color.Green;

                this.GitHubRepositoryLinkLabel.Text = $"https://github.com/{gitHubOwner}/{repositoryName}";
                this.GitHubRepositoryLinkLabel.Show();
            }
            else
            {
                this.ResultLabel.Text = "Not Found";
                this.ResultLabel.ForeColor = Color.Red;

                this.GitHubRepositoryLinkLabel.Hide();
            }
        }

        private void GitHubRepositoryLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var url = this.GitHubRepositoryLinkLabel.Text;

            F0000.UrlOperator.Instance.OpenInBrowser(url);
        }
    }
}
