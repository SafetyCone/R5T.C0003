using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms
{
    public partial class LayoutForRepositoryOperation : LayoutForOperation
    {
        public LayoutForRepositoryOperation()
        {
            InitializeComponent();

            this.OwnerNameSelectorComboBox.Items.AddRange(new[]
            {
                Instances.GitHubOwnerNames.DavidCoats,
                Instances.GitHubOwnerNames.SafetyCone
            });
        }

        private void LayoutForRepositoryOperation_Shown(object sender, EventArgs e)
        {
            this.OwnerNameSelectorComboBox.SelectedItem = Instances.GitHubOwnerNames.SafetyCone;
        }

        protected string GetGitHubOwnerName()
        {
            var gitHubOwnerName = this.OwnerNameSelectorComboBox.SelectedItem as string;
            return gitHubOwnerName;
        }

        protected string GetGitHubOwner()
        {
            var gitHubOwnerName = this.GetGitHubOwnerName();

            var gitHubOwner = Instances.GitHubOwnerOperator.GetGitHubOwner(gitHubOwnerName);
            return gitHubOwner;
        }

        protected string GetRepositoryName()
        {
            var repositoryName = this.RepositoryNameTextBox.Text;
            return repositoryName;
        }
        
        private void OwnerNameSelectorComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            var gitHubOwner = this.GetGitHubOwner();

            this.GitHubOwnerLabel.Text = gitHubOwner;
        }
    }
}
