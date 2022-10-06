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
    public partial class RepositoryExists : Form
    {
        public RepositoryExists()
        {
            InitializeComponent();

            this.OwnerNameSelectorComboBox.Items.AddRange(new[]
            {
                Instances.GitHubOwnerNames.DavidCoats,
                Instances.GitHubOwnerNames.SafetyCone
            });
        }

        private string GetGitHubOwnerName()
        {
            var gitHubOwnerName = this.OwnerNameSelectorComboBox.SelectedItem as string;
            return gitHubOwnerName;
        }

        private string GetGitHubOwner()
        {
            var gitHubOwnerName = this.GetGitHubOwnerName();
            
            var gitHubOwner = Instances.GitHubOwnerOperator.GetGitHubOwner(gitHubOwnerName);
            return gitHubOwner;
        }

        private void OwnerNameSelectorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var gitHubOwner = this.GetGitHubOwner();

            this.GitHubOwnerLabel.Text = gitHubOwner;
        }

        private void RepositoryExists_Shown(object sender, EventArgs e)
        {
            //this.OwnerNameSelectorComboBox.SelectedItem = Instances.GitHubOwnerNames.SafetyCone;
            this.OwnerNameSelectorComboBox.SelectedIndex = 1;
        }

        private async void CheckExistsButton_Click(object sender, EventArgs e)
        {
            var repositoryName = this.RepositoryNameTextBox.Text;
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
