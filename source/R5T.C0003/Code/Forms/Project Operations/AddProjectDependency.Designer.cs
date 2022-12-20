namespace R5T.C0003.Forms.Project
{
    partial class AddProjectDependency
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
            this.SubTitleLabel = new System.Windows.Forms.Label();
            this.DependencyIsProjectFileLabel = new System.Windows.Forms.Label();
            this.DependencyFileExistsLabel = new System.Windows.Forms.Label();
            this.DependencyIsProjectFileLabelLabel = new System.Windows.Forms.Label();
            this.DependencyFileExistsLabelLabel = new System.Windows.Forms.Label();
            this.SelectDependencyProjectFileButton = new System.Windows.Forms.Button();
            this.DependencyProjectFilePathTextBox = new System.Windows.Forms.TextBox();
            this.DependencyProjectFilePathLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.DependencyIsProjectFileLabel);
            this.MainGroupBox.Controls.Add(this.DependencyFileExistsLabel);
            this.MainGroupBox.Controls.Add(this.DependencyIsProjectFileLabelLabel);
            this.MainGroupBox.Controls.Add(this.DependencyFileExistsLabelLabel);
            this.MainGroupBox.Controls.Add(this.SelectDependencyProjectFileButton);
            this.MainGroupBox.Controls.Add(this.DependencyProjectFilePathTextBox);
            this.MainGroupBox.Controls.Add(this.DependencyProjectFilePathLabel);
            this.MainGroupBox.Controls.Add(this.SubTitleLabel);
            this.MainGroupBox.Text = "Add Project Dependency";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.SubTitleLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyProjectFilePathTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.SelectDependencyProjectFileButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyFileExistsLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyIsProjectFileLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyFileExistsLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DependencyIsProjectFileLabel, 0);
            // 
            // SubTitleLabel
            // 
            this.SubTitleLabel.AutoSize = true;
            this.SubTitleLabel.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubTitleLabel.Location = new System.Drawing.Point(28, 30);
            this.SubTitleLabel.Name = "SubTitleLabel";
            this.SubTitleLabel.Size = new System.Drawing.Size(229, 13);
            this.SubTitleLabel.TabIndex = 20;
            this.SubTitleLabel.Text = "Add update solutions in parent directories.";
            // 
            // DependencyIsProjectFileLabel
            // 
            this.DependencyIsProjectFileLabel.AutoSize = true;
            this.DependencyIsProjectFileLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyIsProjectFileLabel.Location = new System.Drawing.Point(277, 253);
            this.DependencyIsProjectFileLabel.Name = "DependencyIsProjectFileLabel";
            this.DependencyIsProjectFileLabel.Size = new System.Drawing.Size(16, 15);
            this.DependencyIsProjectFileLabel.TabIndex = 27;
            this.DependencyIsProjectFileLabel.Text = "...";
            // 
            // DependencyFileExistsLabel
            // 
            this.DependencyFileExistsLabel.AutoSize = true;
            this.DependencyFileExistsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyFileExistsLabel.Location = new System.Drawing.Point(277, 230);
            this.DependencyFileExistsLabel.Name = "DependencyFileExistsLabel";
            this.DependencyFileExistsLabel.Size = new System.Drawing.Size(16, 15);
            this.DependencyFileExistsLabel.TabIndex = 26;
            this.DependencyFileExistsLabel.Text = "...";
            // 
            // DependencyIsProjectFileLabelLabel
            // 
            this.DependencyIsProjectFileLabelLabel.AutoSize = true;
            this.DependencyIsProjectFileLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyIsProjectFileLabelLabel.Location = new System.Drawing.Point(171, 253);
            this.DependencyIsProjectFileLabelLabel.Name = "DependencyIsProjectFileLabelLabel";
            this.DependencyIsProjectFileLabelLabel.Size = new System.Drawing.Size(79, 15);
            this.DependencyIsProjectFileLabelLabel.TabIndex = 25;
            this.DependencyIsProjectFileLabelLabel.Text = "Is project file?";
            // 
            // DependencyFileExistsLabelLabel
            // 
            this.DependencyFileExistsLabelLabel.AutoSize = true;
            this.DependencyFileExistsLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyFileExistsLabelLabel.Location = new System.Drawing.Point(171, 230);
            this.DependencyFileExistsLabelLabel.Name = "DependencyFileExistsLabelLabel";
            this.DependencyFileExistsLabelLabel.Size = new System.Drawing.Size(62, 15);
            this.DependencyFileExistsLabelLabel.TabIndex = 24;
            this.DependencyFileExistsLabelLabel.Text = "File exists?";
            // 
            // SelectDependencyProjectFileButton
            // 
            this.SelectDependencyProjectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectDependencyProjectFileButton.Location = new System.Drawing.Point(13, 225);
            this.SelectDependencyProjectFileButton.Name = "SelectDependencyProjectFileButton";
            this.SelectDependencyProjectFileButton.Size = new System.Drawing.Size(113, 41);
            this.SelectDependencyProjectFileButton.TabIndex = 21;
            this.SelectDependencyProjectFileButton.Text = "Select";
            this.SelectDependencyProjectFileButton.UseVisualStyleBackColor = true;
            // 
            // DependencyProjectFilePathTextBox
            // 
            this.DependencyProjectFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DependencyProjectFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyProjectFilePathTextBox.Location = new System.Drawing.Point(13, 190);
            this.DependencyProjectFilePathTextBox.Name = "DependencyProjectFilePathTextBox";
            this.DependencyProjectFilePathTextBox.Size = new System.Drawing.Size(457, 29);
            this.DependencyProjectFilePathTextBox.TabIndex = 22;
            // 
            // DependencyProjectFilePathLabel
            // 
            this.DependencyProjectFilePathLabel.AutoSize = true;
            this.DependencyProjectFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DependencyProjectFilePathLabel.Location = new System.Drawing.Point(13, 166);
            this.DependencyProjectFilePathLabel.Name = "DependencyProjectFilePathLabel";
            this.DependencyProjectFilePathLabel.Size = new System.Drawing.Size(179, 21);
            this.DependencyProjectFilePathLabel.TabIndex = 23;
            this.DependencyProjectFilePathLabel.Text = "Dependency Project File:";
            // 
            // AddProjectDependency
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddProjectDependency";
            this.Text = "AddProjectDependency";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label SubTitleLabel;
        private System.Windows.Forms.Label DependencyIsProjectFileLabel;
        private System.Windows.Forms.Label DependencyFileExistsLabel;
        private System.Windows.Forms.Label DependencyIsProjectFileLabelLabel;
        private System.Windows.Forms.Label DependencyFileExistsLabelLabel;
        private System.Windows.Forms.Button SelectDependencyProjectFileButton;
        private System.Windows.Forms.TextBox DependencyProjectFilePathTextBox;
        protected System.Windows.Forms.Label DependencyProjectFilePathLabel;
    }
}