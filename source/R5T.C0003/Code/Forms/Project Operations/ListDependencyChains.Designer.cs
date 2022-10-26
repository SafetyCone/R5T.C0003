namespace R5T.C0003.Forms.Project
{
    partial class ListDependencyChains
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
            this.IsProjectDependencyFileLabel = new System.Windows.Forms.Label();
            this.DependencyFileExistsLabel = new System.Windows.Forms.Label();
            this.IsProjectDependencyFileLabelLabel = new System.Windows.Forms.Label();
            this.DependencyFileExistsLabelLabel = new System.Windows.Forms.Label();
            this.SelectDependencyProjectFileButton = new System.Windows.Forms.Button();
            this.DependencyProjectFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DepdencyProjectFilePathLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // ProjectFilePathLabel
            // 
            this.ProjectFilePathLabel.Size = new System.Drawing.Size(126, 21);
            this.ProjectFilePathLabel.Text = "Root Project File:";
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.IsProjectDependencyFileLabel);
            this.MainGroupBox.Controls.Add(this.DependencyFileExistsLabel);
            this.MainGroupBox.Controls.Add(this.IsProjectDependencyFileLabelLabel);
            this.MainGroupBox.Controls.Add(this.DependencyFileExistsLabelLabel);
            this.MainGroupBox.Controls.Add(this.SelectDependencyProjectFileButton);
            this.MainGroupBox.Controls.Add(this.DependencyProjectFilePathTextBox);
            this.MainGroupBox.Controls.Add(this.DepdencyProjectFilePathLabel);
            this.MainGroupBox.Text = "List Dependency Chains";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DepdencyProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyProjectFilePathTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.SelectDependencyProjectFileButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyFileExistsLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.IsProjectDependencyFileLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyFileExistsLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.IsProjectDependencyFileLabel, 0);
            // 
            // IsProjectDependencyFileLabel
            // 
            this.IsProjectDependencyFileLabel.AutoSize = true;
            this.IsProjectDependencyFileLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsProjectDependencyFileLabel.Location = new System.Drawing.Point(277, 261);
            this.IsProjectDependencyFileLabel.Name = "IsProjectDependencyFileLabel";
            this.IsProjectDependencyFileLabel.Size = new System.Drawing.Size(16, 15);
            this.IsProjectDependencyFileLabel.TabIndex = 26;
            this.IsProjectDependencyFileLabel.Text = "...";
            // 
            // DependencyFileExistsLabel
            // 
            this.DependencyFileExistsLabel.AutoSize = true;
            this.DependencyFileExistsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyFileExistsLabel.Location = new System.Drawing.Point(277, 238);
            this.DependencyFileExistsLabel.Name = "DependencyFileExistsLabel";
            this.DependencyFileExistsLabel.Size = new System.Drawing.Size(16, 15);
            this.DependencyFileExistsLabel.TabIndex = 25;
            this.DependencyFileExistsLabel.Text = "...";
            // 
            // IsProjectDependencyFileLabelLabel
            // 
            this.IsProjectDependencyFileLabelLabel.AutoSize = true;
            this.IsProjectDependencyFileLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsProjectDependencyFileLabelLabel.Location = new System.Drawing.Point(171, 261);
            this.IsProjectDependencyFileLabelLabel.Name = "IsProjectDependencyFileLabelLabel";
            this.IsProjectDependencyFileLabelLabel.Size = new System.Drawing.Size(79, 15);
            this.IsProjectDependencyFileLabelLabel.TabIndex = 24;
            this.IsProjectDependencyFileLabelLabel.Text = "Is project file?";
            // 
            // DependencyFileExistsLabelLabel
            // 
            this.DependencyFileExistsLabelLabel.AutoSize = true;
            this.DependencyFileExistsLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyFileExistsLabelLabel.Location = new System.Drawing.Point(171, 238);
            this.DependencyFileExistsLabelLabel.Name = "DependencyFileExistsLabelLabel";
            this.DependencyFileExistsLabelLabel.Size = new System.Drawing.Size(62, 15);
            this.DependencyFileExistsLabelLabel.TabIndex = 23;
            this.DependencyFileExistsLabelLabel.Text = "File exists?";
            // 
            // SelectDependencyProjectFileButton
            // 
            this.SelectDependencyProjectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectDependencyProjectFileButton.Location = new System.Drawing.Point(13, 233);
            this.SelectDependencyProjectFileButton.Name = "SelectDependencyProjectFileButton";
            this.SelectDependencyProjectFileButton.Size = new System.Drawing.Size(113, 41);
            this.SelectDependencyProjectFileButton.TabIndex = 20;
            this.SelectDependencyProjectFileButton.Text = "Select";
            this.SelectDependencyProjectFileButton.UseVisualStyleBackColor = true;
            // 
            // DependencyProjectFilePathTextBox
            // 
            this.DependencyProjectFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyProjectFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyProjectFilePathTextBox.Location = new System.Drawing.Point(13, 198);
            this.DependencyProjectFilePathTextBox.Name = "DependencyProjectFilePathTextBox";
            this.DependencyProjectFilePathTextBox.Size = new System.Drawing.Size(457, 29);
            this.DependencyProjectFilePathTextBox.TabIndex = 21;
            // 
            // DepdencyProjectFilePathLabel
            // 
            this.DepdencyProjectFilePathLabel.AutoSize = true;
            this.DepdencyProjectFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DepdencyProjectFilePathLabel.Location = new System.Drawing.Point(13, 174);
            this.DepdencyProjectFilePathLabel.Name = "DepdencyProjectFilePathLabel";
            this.DepdencyProjectFilePathLabel.Size = new System.Drawing.Size(179, 21);
            this.DepdencyProjectFilePathLabel.TabIndex = 22;
            this.DepdencyProjectFilePathLabel.Text = "Dependency Project File:";
            // 
            // ListDependencyChains
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "ListDependencyChains";
            this.Text = "ListDependencyPaths";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IsProjectDependencyFileLabel;
        private System.Windows.Forms.Label DependencyFileExistsLabel;
        private System.Windows.Forms.Label IsProjectDependencyFileLabelLabel;
        private System.Windows.Forms.Label DependencyFileExistsLabelLabel;
        private System.Windows.Forms.Button SelectDependencyProjectFileButton;
        private System.Windows.Forms.TextBox DependencyProjectFilePathTextBox;
        private System.Windows.Forms.Label DepdencyProjectFilePathLabel;
    }
}