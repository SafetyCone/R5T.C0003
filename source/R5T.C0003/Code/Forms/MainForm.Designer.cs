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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Exists");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("New Library");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Repository", new System.Windows.Forms.TreeNode[] {
                treeNode2,
                treeNode1});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Solution");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Project");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Code");
            this.OperationsTreeView = new System.Windows.Forms.TreeView();
            this.OperationPanel = new System.Windows.Forms.Panel();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpAboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            treeNode1.Name = "RepositoryExistsNode";
            treeNode1.Text = "Exists";
            treeNode2.Name = "CreateLibraryRepositoryNode";
            treeNode2.Text = "New Library";
            treeNode3.Name = "RepositoryOperationsNode";
            treeNode3.Text = "Repository";
            treeNode4.Name = "SolutionOperationsNode";
            treeNode4.Text = "Solution";
            treeNode5.Name = "ProjectOperationsNode";
            treeNode5.Text = "Project";
            treeNode6.Name = "CodeOperationsNode";
            treeNode6.Text = "Code";
            this.OperationsTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.OperationsTreeView.Size = new System.Drawing.Size(284, 398);
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
            this.OperationPanel.Size = new System.Drawing.Size(486, 398);
            this.OperationPanel.TabIndex = 1;
            // 
            // StatusStrip
            // 
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel});
            this.StatusStrip.Location = new System.Drawing.Point(0, 428);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.Size = new System.Drawing.Size(800, 22);
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
            this.Menu.Size = new System.Drawing.Size(800, 24);
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.Menu);
            this.Controls.Add(this.OperationPanel);
            this.Controls.Add(this.OperationsTreeView);
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
    }
}