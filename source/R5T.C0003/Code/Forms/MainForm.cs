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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            this.OperationsTreeView.Nodes["RepositoryOperationsNode"].Expand();
        }

        public void SelectOperationNode(string nodeName)
        {
            var node = this.OperationsTreeView.Nodes.Find(nodeName, true).Single();

            this.OperationsTreeView.SelectedNode = node;
        }

        private void HelpAboutMenuItem_Click(object sender, EventArgs e)
        {
            var about = new About();

            about.ShowDialog();
        }

        private void OperationsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            // Clear all first.
            this.OperationPanel.Controls.Clear();

            if (e.Node.Name == "RepositoryExistsNode")
            {
                var repositoryExistsForm = new Repository.RepositoryExists
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };

                this.OperationPanel.Controls.Add(repositoryExistsForm);

                repositoryExistsForm.Show();

                return;
            }

            if (e.Node.Name == "CreateLibraryRepositoryNode")
            {
                var newLibraryForm = new Repository.NewLibrary
                {
                    Dock = DockStyle.Fill,
                    TopLevel = false,
                    TopMost = true,
                };

                this.OperationPanel.Controls.Add(newLibraryForm);

                newLibraryForm.Show();

                return;
            }
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Program.Testing(this);
        }
    }
}
