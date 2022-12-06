using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0062;


namespace R5T.C0003.Forms
{
    public partial class MainForm : Form, IHasNotifyIcon
    {
        private IServiceProvider ServiceProvider { get; }

        NotifyIcon IHasNotifyIcon.NotifyIcon => this.NotifyIcon;


        public MainForm(
            IServiceProvider serviceProvider)
        {
            InitializeComponent();

            this.ServiceProvider = serviceProvider;

            // Discard the disengage action.
            _ = F0062.NotifyIconOperator.Instance.EngageMinimizeToSystemTray(this);

            this.OperationsTreeView.Nodes[Instances.TreeViewNodeNames.RepositoryOperationsNode].Expand();
            this.OperationsTreeView.Nodes[Instances.TreeViewNodeNames.SolutionOperationsNode].Expand();
            this.OperationsTreeView.Nodes[Instances.TreeViewNodeNames.ProjectOperationsNode].Expand();
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

        private TRepositoryOperation GetRepositoryOperationAsService<TRepositoryOperation>()
            where TRepositoryOperation : LayoutForRepositoryOperation
        {
            var output = this.ServiceProvider.GetRequiredService<TRepositoryOperation>();

            output.Setup();

            return output;
        }

        private TRepositoryOperation GetRepositoryOperation<TRepositoryOperation>()
            where TRepositoryOperation : LayoutForRepositoryOperation, new()
        {
            var output = new TRepositoryOperation();

            output.Setup();

            return output;
        }

        private void OperationsTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var panelFormConstructorsByTreeViewNodeName = new Dictionary<string, Func<Form>>
            {
                { Instances.TreeViewNodeNames.AddMissingDependenciesSolutionNode, () => new Solution.AddMissingDependencies() },
                { Instances.TreeViewNodeNames.AddServiceDefinitionToProjectNode, () => new Project.AddServiceDefinition() },
                { Instances.TreeViewNodeNames.AddStronglyTypedTypeNode, () => new Project.AddStronglyTypedType() },
                { Instances.TreeViewNodeNames.CreateLibraryRepositoryNode, () => this.GetRepositoryOperationAsService<Repository.NewLibrary>() },
                { Instances.TreeViewNodeNames.GenerateS3BucketNameOperation, () =>  new AWS.S3.GenerateBucketName() },
                { Instances.TreeViewNodeNames.IdentifyExtraneousProjectReferencesNode, () =>  new Project.IdentifyExtraneousProjectReferences() },
                { Instances.TreeViewNodeNames.ListAllDependenciesSolutionNode, () => new Solution.ListAllDependencies() },
                { Instances.TreeViewNodeNames.ListDependencyChainsProjectNode, () => new Project.ListDependencyChains() },
                { Instances.TreeViewNodeNames.ListRecursiveDependenciesProjectNode, () => new Project.ListRecursiveDependencies() },
                { Instances.TreeViewNodeNames.NewConsoleRepositoryNode, () => this.GetRepositoryOperationAsService<Repository.NewConsole>() },
                { Instances.TreeViewNodeNames.NewGuidNode, () => new Miscellaneous.NewGuid() },
                { Instances.TreeViewNodeNames.NewProgramAsServiceRepositoryNode, () => this.GetRepositoryOperationAsService<Repository.NewConsoleProgramAsService>() },
                { Instances.TreeViewNodeNames.NewRepositoryOnlyNode, () => this.GetRepositoryOperationAsService<Repository.NewRepositoryOnly>() },
                { Instances.TreeViewNodeNames.NewWebApplicationRepositoryNode, () => this.GetRepositoryOperationAsService<Repository.NewWebApplication>() },
                { Instances.TreeViewNodeNames.NewWebStaticRazorComponents, () => this.GetRepositoryOperation<Repository.NewWebStaticRazorComponents>() },
                { Instances.TreeViewNodeNames.RepositoryExistsNode, () => this.GetRepositoryOperation<Repository.RepositoryExists>() },
                { Instances.TreeViewNodeNames.RemoveExtraneousDependenciesSolutionNode, () => new Solution.RemoveExtraneousDependencies() },
                { Instances.TreeViewNodeNames.RemoveExtraneousProjectReferencesNode, () => new Project.RemoveExtraneousProjectReferences() },
                { Instances.TreeViewNodeNames.UpdateAddXMethodsProjectNode, () => new Project.UpdateAddXMethods() },
                { Instances.TreeViewNodeNames.UpdateAddXMethodsSolutionNode, () => new Solution.UpdateAddXMethods() },
            };

            var selectedNodeName = e.Node.Name;

            // Return if an unrecognized node.
            if(!panelFormConstructorsByTreeViewNodeName.ContainsKey(selectedNodeName))
            {
                return;
            }

            // Now we have a recognized node.
            var constructor = panelFormConstructorsByTreeViewNodeName[selectedNodeName];

            var panelForm = constructor();

            // Handle any setup that must be off the WinForms designer initialzation path.
            if(panelForm is IHasNonWinFormsDesginerSetup hasNonWinFormsDesginerSetup)
            {
                hasNonWinFormsDesginerSetup.Setup();
            }

            // Set panel form.
            // Clear all first.
            this.OperationPanel.Controls.Clear();

            panelForm.Dock = DockStyle.Fill;
            panelForm.TopLevel = false;
            panelForm.TopMost = false;

            this.OperationPanel.Controls.Add(panelForm);

            panelForm.Show();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Program.Testing(this);
        }
    }
}
