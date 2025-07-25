using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0047;


namespace R5T.C0003.Forms
{
    public partial class LayoutForRepositoryOperation : LayoutForOperation
    {
        public LayoutForRepositoryOperation()
        {
            InitializeComponent();

            //this.Setup();
        }

        /// <summary>
        /// Use a setup method to keep code in non-direct project references of the WinForms project off the WinForms designer initialization pathway.
        /// This method is called from the main form generation.
        /// </summary>
        public void Setup()
        {
            this.OwnerNameSelectorComboBox.Items.AddRange(
                Instances.GitHubOwnerNameSets.All);

            this.OwnerNameSelectorComboBox.SelectedItem = GitHubOwnerNames.Instance.Functionairy;
        }

        //private void LayoutForRepositoryOperation_Shown(object sender, EventArgs e)
        //{
        //    this.OwnerNameSelectorComboBox.SelectedItem = GitHubOwnerNames.Instance.SafetyCone;
        //}

        protected string GetGitHubOwnerName()
        {
            var gitHubOwnerName = this.OwnerNameSelectorComboBox.SelectedItem as string;
            return gitHubOwnerName;
        }

        protected string GetGitHubOwner()
        {
            var gitHubOwnerName = this.GetGitHubOwnerName();

            var gitHubOwner = GitHubOwnerOperator.Instance.Get_GitHubOwner(gitHubOwnerName);
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
