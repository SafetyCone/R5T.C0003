namespace R5T.C0003.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("New Library");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Exists");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("New Console");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("New Program-as-Service");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("New Web Application");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Repository", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Virconium-Add Missing Project Dependencies");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("List Missing Project Dependencies");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("List All Project Dependencies");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Solution", new System.Windows.Forms.TreeNode[] {
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Jarlshof-List Recursive Dependencies");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Project", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Code");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OperationsTreeView = new System.Windows.Forms.TreeView();
            this.OperationPanel = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.NotifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.StatusStrip.SuspendLayout();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperationsTreeView
            // 
            this.OperationsTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.OperationsTreeView.Location = new System.Drawing.Point(12, 27);
            this.OperationsTreeView.Name = "OperationsTreeView";
            treeNode1.Name = "CreateLibraryRepositoryNode";
            treeNode1.Text = "New Library";
            treeNode2.Name = "RepositoryExistsNode";
            treeNode2.Text = "Exists";
            treeNode3.Name = "NewConsoleRepositoryNode";
            treeNode3.Text = "New Console";
            treeNode4.Name = "NewProgramAsServiceRepositoryNode";
            treeNode4.Text = "New Program-as-Service";
            treeNode5.Name = "NewWebApplicationRepositoryNode";
            treeNode5.Text = "New Web Application";
            treeNode6.Name = "RepositoryOperationsNode";
            treeNode6.Text = "Repository";
            treeNode7.Name = "AddMissingDependenciesSolutionNode";
            treeNode7.Text = "Virconium-Add Missing Project Dependencies";
            treeNode8.Name = "ListMissingDependenciesSolutionNode";
            treeNode8.Text = "List Missing Project Dependencies";
            treeNode9.Name = "ListAllDependenciesSolutionNode";
            treeNode9.Text = "List All Project Dependencies";
            treeNode10.Name = "SolutionOperationsNode";
            treeNode10.Text = "Solution";
            treeNode11.Name = "ListRecursiveDependenciesProjectNode";
            treeNode11.Text = "Jarlshof-List Recursive Dependencies";
            treeNode12.Name = "ProjectOperationsNode";
            treeNode12.Text = "Project";
            treeNode13.Name = "CodeOperationsNode";
            treeNode13.Text = "Code";
            this.OperationsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode10,
            treeNode12,
            treeNode13});
            this.OperationsTreeView.Size = new System.Drawing.Size(284, 404);
            this.OperationsTreeView.TabIndex = 0;
            this.OperationsTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.OperationsTreeView_AfterSelect);
            // 
            // OperationPanel
            // 
            this.OperationPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OperationPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OperationPanel.Location = new System.Drawing.Point(302, 27);
            this.OperationPanel.Name = "OperationPanel";
            this.OperationPanel.Size = new System.Drawing.Size(505, 404);
            this.OperationPanel.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 434);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(819, 22);
            this.StatusStrip.TabIndex = 2;
            this.StatusStrip.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(16, 17);
            this.StatusLabel.Text = "...";
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpMenuItem});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(819, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.HelpAboutMenuItem});
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = "&Help";
            // 
            // HelpAboutMenuItem
            // 
            this.HelpAboutMenuItem.Name = "HelpAboutMenuItem";
            this.HelpAboutMenuItem.Size = new System.Drawing.Size(107, 22);
            this.HelpAboutMenuItem.Text = "&About";
            this.HelpAboutMenuItem.Click += new System.EventHandler(this.HelpAboutMenuItem_Click);
            // 
            // NotifyIcon
            // 
            this.NotifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIcon.Icon")));
            this.NotifyIcon.Text = "Ithaca";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 456);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.OperationPanel);
            this.Controls.Add(this.OperationsTreeView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Name = "MainForm";
            this.Text = "Ithaca";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView OperationsTreeView;
        private System.Windows.Forms.Panel OperationPanel;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpAboutMenuItem;
        private System.Windows.Forms.NotifyIcon NotifyIcon;
    }
}