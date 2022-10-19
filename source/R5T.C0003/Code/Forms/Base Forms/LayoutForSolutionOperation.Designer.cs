namespace R5T.C0003.Forms
{
    partial class LayoutForSolutionOperation
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
            this.SolutionFilePathTextBox = new System.Windows.Forms.TextBox();
            this.SolutionFilePathLabel = new System.Windows.Forms.Label();
            this.SolutionFileOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SelectSolutionFileButton = new System.Windows.Forms.Button();
            this.FileExistsLabelLabel = new System.Windows.Forms.Label();
            this.IsSolutionFileLabelLabel = new System.Windows.Forms.Label();
            this.FileExistsLabel = new System.Windows.Forms.Label();
            this.IsSolutionFileLabel = new System.Windows.Forms.Label();
            this.RunButton = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.RunButton);
            this.MainGroupBox.Controls.Add(this.IsSolutionFileLabel);
            this.MainGroupBox.Controls.Add(this.FileExistsLabel);
            this.MainGroupBox.Controls.Add(this.IsSolutionFileLabelLabel);
            this.MainGroupBox.Controls.Add(this.FileExistsLabelLabel);
            this.MainGroupBox.Controls.Add(this.SelectSolutionFileButton);
            this.MainGroupBox.Controls.Add(this.SolutionFilePathTextBox);
            this.MainGroupBox.Controls.Add(this.SolutionFilePathLabel);
            // 
            // SolutionFilePathTextBox
            // 
            this.SolutionFilePathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SolutionFilePathTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolutionFilePathTextBox.Location = new System.Drawing.Point(13, 69);
            this.SolutionFilePathTextBox.Name = "SolutionFilePathTextBox";
            this.SolutionFilePathTextBox.Size = new System.Drawing.Size(457, 29);
            this.SolutionFilePathTextBox.TabIndex = 10;
            this.SolutionFilePathTextBox.TextChanged += new System.EventHandler(this.SolutionFilePathTextBox_TextChanged);
            // 
            // SolutionFilePathLabel
            // 
            this.SolutionFilePathLabel.AutoSize = true;
            this.SolutionFilePathLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SolutionFilePathLabel.Location = new System.Drawing.Point(13, 45);
            this.SolutionFilePathLabel.Name = "SolutionFilePathLabel";
            this.SolutionFilePathLabel.Size = new System.Drawing.Size(99, 21);
            this.SolutionFilePathLabel.TabIndex = 12;
            this.SolutionFilePathLabel.Text = "Solution File:";
            // 
            // SolutionFileOpenFileDialog
            // 
            this.SolutionFileOpenFileDialog.Filter = "Solution Files (*.sln)|*.sln";
            this.SolutionFileOpenFileDialog.Title = "Select Solution File";
            // 
            // SelectSolutionFileButton
            // 
            this.SelectSolutionFileButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SelectSolutionFileButton.Location = new System.Drawing.Point(13, 104);
            this.SelectSolutionFileButton.Name = "SelectSolutionFileButton";
            this.SelectSolutionFileButton.Size = new System.Drawing.Size(113, 41);
            this.SelectSolutionFileButton.TabIndex = 1;
            this.SelectSolutionFileButton.Text = "Select";
            this.SelectSolutionFileButton.UseVisualStyleBackColor = true;
            this.SelectSolutionFileButton.Click += new System.EventHandler(this.SelectSolutionFileButton_Click);
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
            // IsSolutionFileLabelLabel
            // 
            this.IsSolutionFileLabelLabel.AutoSize = true;
            this.IsSolutionFileLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsSolutionFileLabelLabel.Location = new System.Drawing.Point(30, 192);
            this.IsSolutionFileLabelLabel.Name = "IsSolutionFileLabelLabel";
            this.IsSolutionFileLabelLabel.Size = new System.Drawing.Size(85, 15);
            this.IsSolutionFileLabelLabel.TabIndex = 14;
            this.IsSolutionFileLabelLabel.Text = "Is solution file?";
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
            // IsSolutionFileLabel
            // 
            this.IsSolutionFileLabel.AutoSize = true;
            this.IsSolutionFileLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsSolutionFileLabel.Location = new System.Drawing.Point(136, 192);
            this.IsSolutionFileLabel.Name = "IsSolutionFileLabel";
            this.IsSolutionFileLabel.Size = new System.Drawing.Size(16, 15);
            this.IsSolutionFileLabel.TabIndex = 16;
            this.IsSolutionFileLabel.Text = "...";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(370, 331);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 39);
            this.RunButton.TabIndex = 18;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            // 
            // LayoutForSolutionOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "LayoutForSolutionOperation";
            this.Text = "LayoutForSolutionOperation";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectSolutionFileButton;
        protected System.Windows.Forms.TextBox SolutionFilePathTextBox;
        private System.Windows.Forms.Label SolutionFilePathLabel;
        private System.Windows.Forms.OpenFileDialog SolutionFileOpenFileDialog;
        private System.Windows.Forms.Label IsSolutionFileLabel;
        private System.Windows.Forms.Label FileExistsLabel;
        private System.Windows.Forms.Label IsSolutionFileLabelLabel;
        private System.Windows.Forms.Label FileExistsLabelLabel;
        protected System.Windows.Forms.Button RunButton;
    }
}