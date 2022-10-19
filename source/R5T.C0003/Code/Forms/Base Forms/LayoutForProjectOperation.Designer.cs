namespace R5T.C0003.Forms
{
    partial class LayoutForProjectOperation
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
            this.ProjectFilePathTextBox = new System.Windows.Forms.TextBox();
            this.ProjectFilePathLabel = new System.Windows.Forms.Label();
            this.ProjectFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectProjectFileButton = new System.Windows.Forms.Button();
            this.FileExistsLabelLabel = new System.Windows.Forms.Label();
            this.IsProjectFileLabelLabel = new System.Windows.Forms.Label();
            this.FileExistsLabel = new System.Windows.Forms.Label();
            this.IsProjectFileLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.RunButton);
            this.MainGroupBox.Controls.Add(this.IsProjectFileLabel);
            this.MainGroupBox.Controls.Add(this.FileExistsLabel);
            this.MainGroupBox.Controls.Add(this.IsProjectFileLabelLabel);
            this.MainGroupBox.Controls.Add(this.FileExistsLabelLabel);
            this.MainGroupBox.Controls.Add(this.SelectProjectFileButton);
            this.MainGroupBox.Controls.Add(this.ProjectFilePathTextBox);
            this.MainGroupBox.Controls.Add(this.ProjectFilePathLabel);
            // 
            // ProjectFilePathTextBox
            // 
            this.ProjectFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProjectFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectFilePathTextBox.Location = new System.Drawing.Point(13, 69);
            this.ProjectFilePathTextBox.Name = "ProjectFilePathTextBox";
            this.ProjectFilePathTextBox.Size = new System.Drawing.Size(457, 29);
            this.ProjectFilePathTextBox.TabIndex = 10;
            this.ProjectFilePathTextBox.TextChanged += new System.EventHandler(this.ProjectFilePathTextBox_TextChanged);
            // 
            // ProjectFilePathLabel
            // 
            this.ProjectFilePathLabel.AutoSize = true;
            this.ProjectFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ProjectFilePathLabel.Location = new System.Drawing.Point(13, 45);
            this.ProjectFilePathLabel.Name = "ProjectFilePathLabel";
            this.ProjectFilePathLabel.Size = new System.Drawing.Size(89, 21);
            this.ProjectFilePathLabel.TabIndex = 12;
            this.ProjectFilePathLabel.Text = "Project File:";
            // 
            // ProjectFileOpenFileDialog
            // 
            this.ProjectFileOpenFileDialog.Filter = "C# Project Files (*.csproj)|*.csproj";
            this.ProjectFileOpenFileDialog.Title = "Select C# Project File";
            // 
            // SelectProjectFileButton
            // 
            this.SelectProjectFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectProjectFileButton.Location = new System.Drawing.Point(13, 104);
            this.SelectProjectFileButton.Name = "SelectProjectFileButton";
            this.SelectProjectFileButton.Size = new System.Drawing.Size(113, 41);
            this.SelectProjectFileButton.TabIndex = 1;
            this.SelectProjectFileButton.Text = "Select";
            this.SelectProjectFileButton.UseVisualStyleBackColor = true;
            this.SelectProjectFileButton.Click += new System.EventHandler(this.SelectProjectFileButton_Click);
            // 
            // FileExistsLabelLabel
            // 
            this.FileExistsLabelLabel.AutoSize = true;
            this.FileExistsLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileExistsLabelLabel.Location = new System.Drawing.Point(30, 169);
            this.FileExistsLabelLabel.Name = "FileExistsLabelLabel";
            this.FileExistsLabelLabel.Size = new System.Drawing.Size(62, 15);
            this.FileExistsLabelLabel.TabIndex = 13;
            this.FileExistsLabelLabel.Text = "File exists?";
            // 
            // IsProjectFileLabelLabel
            // 
            this.IsProjectFileLabelLabel.AutoSize = true;
            this.IsProjectFileLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsProjectFileLabelLabel.Location = new System.Drawing.Point(30, 192);
            this.IsProjectFileLabelLabel.Name = "IsProjectFileLabelLabel";
            this.IsProjectFileLabelLabel.Size = new System.Drawing.Size(79, 15);
            this.IsProjectFileLabelLabel.TabIndex = 14;
            this.IsProjectFileLabelLabel.Text = "Is project file?";
            // 
            // FileExistsLabel
            // 
            this.FileExistsLabel.AutoSize = true;
            this.FileExistsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FileExistsLabel.Location = new System.Drawing.Point(136, 169);
            this.FileExistsLabel.Name = "FileExistsLabel";
            this.FileExistsLabel.Size = new System.Drawing.Size(16, 15);
            this.FileExistsLabel.TabIndex = 15;
            this.FileExistsLabel.Text = "...";
            // 
            // IsProjectFileLabel
            // 
            this.IsProjectFileLabel.AutoSize = true;
            this.IsProjectFileLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsProjectFileLabel.Location = new System.Drawing.Point(136, 192);
            this.IsProjectFileLabel.Name = "IsProjectFileLabel";
            this.IsProjectFileLabel.Size = new System.Drawing.Size(16, 15);
            this.IsProjectFileLabel.TabIndex = 16;
            this.IsProjectFileLabel.Text = "...";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(370, 331);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 39);
            this.RunButton.TabIndex = 19;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // LayoutForProjectOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "LayoutForProjectOperation";
            this.Text = "LayoutForSolutionOperation";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectProjectFileButton;
        protected System.Windows.Forms.TextBox ProjectFilePathTextBox;
        private System.Windows.Forms.Label ProjectFilePathLabel;
        private System.Windows.Forms.OpenFileDialog ProjectFileOpenFileDialog;
        private System.Windows.Forms.Label IsProjectFileLabel;
        private System.Windows.Forms.Label FileExistsLabel;
        private System.Windows.Forms.Label IsProjectFileLabelLabel;
        private System.Windows.Forms.Label FileExistsLabelLabel;
        private System.Windows.Forms.Button RunButton;
    }
}