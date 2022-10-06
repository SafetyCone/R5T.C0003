namespace R5T.C0003.Forms.Repository
{
    partial class RepositoryExists
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
            this.MainGroupBox = new System.Windows.Forms.GroupBox();
            this.GitHubRepositoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultLabelLabel = new System.Windows.Forms.Label();
            this.CheckExistsButton = new System.Windows.Forms.Button();
            this.RepositoryNameTextBox = new System.Windows.Forms.TextBox();
            this.RepositoryNameLabel = new System.Windows.Forms.Label();
            this.GitHubOwnerLabel = new System.Windows.Forms.Label();
            this.GitHubOwnerLabelLabel = new System.Windows.Forms.Label();
            this.OwnerNameSelectorComboBox = new System.Windows.Forms.ComboBox();
            this.OwnerNameLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainGroupBox.Controls.Add(this.GitHubRepositoryLinkLabel);
            this.MainGroupBox.Controls.Add(this.ResultLabel);
            this.MainGroupBox.Controls.Add(this.ResultLabelLabel);
            this.MainGroupBox.Controls.Add(this.CheckExistsButton);
            this.MainGroupBox.Controls.Add(this.RepositoryNameTextBox);
            this.MainGroupBox.Controls.Add(this.RepositoryNameLabel);
            this.MainGroupBox.Controls.Add(this.GitHubOwnerLabel);
            this.MainGroupBox.Controls.Add(this.GitHubOwnerLabelLabel);
            this.MainGroupBox.Controls.Add(this.OwnerNameSelectorComboBox);
            this.MainGroupBox.Controls.Add(this.OwnerNameLabel);
            this.MainGroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MainGroupBox.Location = new System.Drawing.Point(12, 12);
            this.MainGroupBox.Name = "MainGroupBox";
            this.MainGroupBox.Size = new System.Drawing.Size(476, 376);
            this.MainGroupBox.TabIndex = 0;
            this.MainGroupBox.TabStop = false;
            this.MainGroupBox.Text = "GitHub Repository Exists";
            // 
            // GitHubRepositoryLinkLabel
            // 
            this.GitHubRepositoryLinkLabel.AutoSize = true;
            this.GitHubRepositoryLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubRepositoryLinkLabel.Location = new System.Drawing.Point(41, 335);
            this.GitHubRepositoryLinkLabel.Name = "GitHubRepositoryLinkLabel";
            this.GitHubRepositoryLinkLabel.Size = new System.Drawing.Size(56, 15);
            this.GitHubRepositoryLinkLabel.TabIndex = 4;
            this.GitHubRepositoryLinkLabel.TabStop = true;
            this.GitHubRepositoryLinkLabel.Text = "https://...";
            this.GitHubRepositoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.GitHubRepositoryLinkLabel_LinkClicked);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(102, 295);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(29, 32);
            this.ResultLabel.TabIndex = 8;
            this.ResultLabel.Text = "...";
            // 
            // ResultLabelLabel
            // 
            this.ResultLabelLabel.AutoSize = true;
            this.ResultLabelLabel.Location = new System.Drawing.Point(13, 295);
            this.ResultLabelLabel.Name = "ResultLabelLabel";
            this.ResultLabelLabel.Size = new System.Drawing.Size(83, 32);
            this.ResultLabelLabel.TabIndex = 7;
            this.ResultLabelLabel.Text = "Result:";
            // 
            // CheckExistsButton
            // 
            this.CheckExistsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckExistsButton.Location = new System.Drawing.Point(13, 228);
            this.CheckExistsButton.Name = "CheckExistsButton";
            this.CheckExistsButton.Size = new System.Drawing.Size(102, 48);
            this.CheckExistsButton.TabIndex = 3;
            this.CheckExistsButton.Text = "Check";
            this.CheckExistsButton.UseVisualStyleBackColor = true;
            this.CheckExistsButton.Click += new System.EventHandler(this.CheckExistsButton_Click);
            // 
            // RepositoryNameTextBox
            // 
            this.RepositoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepositoryNameTextBox.Location = new System.Drawing.Point(13, 69);
            this.RepositoryNameTextBox.Name = "RepositoryNameTextBox";
            this.RepositoryNameTextBox.Size = new System.Drawing.Size(257, 29);
            this.RepositoryNameTextBox.TabIndex = 0;
            // 
            // RepositoryNameLabel
            // 
            this.RepositoryNameLabel.AutoSize = true;
            this.RepositoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepositoryNameLabel.Location = new System.Drawing.Point(13, 45);
            this.RepositoryNameLabel.Name = "RepositoryNameLabel";
            this.RepositoryNameLabel.Size = new System.Drawing.Size(134, 21);
            this.RepositoryNameLabel.TabIndex = 4;
            this.RepositoryNameLabel.Text = "Repository Name:";
            // 
            // GitHubOwnerLabel
            // 
            this.GitHubOwnerLabel.AutoSize = true;
            this.GitHubOwnerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubOwnerLabel.Location = new System.Drawing.Point(119, 186);
            this.GitHubOwnerLabel.Name = "GitHubOwnerLabel";
            this.GitHubOwnerLabel.Size = new System.Drawing.Size(16, 15);
            this.GitHubOwnerLabel.TabIndex = 3;
            this.GitHubOwnerLabel.Text = "...";
            // 
            // GitHubOwnerLabelLabel
            // 
            this.GitHubOwnerLabelLabel.AutoSize = true;
            this.GitHubOwnerLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubOwnerLabelLabel.Location = new System.Drawing.Point(27, 186);
            this.GitHubOwnerLabelLabel.Name = "GitHubOwnerLabelLabel";
            this.GitHubOwnerLabelLabel.Size = new System.Drawing.Size(86, 15);
            this.GitHubOwnerLabelLabel.TabIndex = 2;
            this.GitHubOwnerLabelLabel.Text = "GitHub Owner:";
            // 
            // OwnerNameSelectorComboBox
            // 
            this.OwnerNameSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerNameSelectorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerNameSelectorComboBox.FormattingEnabled = true;
            this.OwnerNameSelectorComboBox.Location = new System.Drawing.Point(13, 147);
            this.OwnerNameSelectorComboBox.Name = "OwnerNameSelectorComboBox";
            this.OwnerNameSelectorComboBox.Size = new System.Drawing.Size(257, 29);
            this.OwnerNameSelectorComboBox.TabIndex = 1;
            this.OwnerNameSelectorComboBox.SelectedValueChanged += new System.EventHandler(this.OwnerNameSelectorComboBox_SelectedValueChanged);
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.AutoSize = true;
            this.OwnerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerNameLabel.Location = new System.Drawing.Point(13, 123);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(106, 21);
            this.OwnerNameLabel.TabIndex = 0;
            this.OwnerNameLabel.Text = "Owner Name:";
            // 
            // RepositoryExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Controls.Add(this.MainGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RepositoryExists";
            this.Text = "RepositoryExists";
            this.Shown += new System.EventHandler(this.RepositoryExists_Shown);
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MainGroupBox;
        private System.Windows.Forms.LinkLabel GitHubRepositoryLinkLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultLabelLabel;
        private System.Windows.Forms.Button CheckExistsButton;
        private System.Windows.Forms.TextBox RepositoryNameTextBox;
        private System.Windows.Forms.Label RepositoryNameLabel;
        private System.Windows.Forms.Label GitHubOwnerLabel;
        private System.Windows.Forms.Label GitHubOwnerLabelLabel;
        private System.Windows.Forms.ComboBox OwnerNameSelectorComboBox;
        private System.Windows.Forms.Label OwnerNameLabel;
    }
}