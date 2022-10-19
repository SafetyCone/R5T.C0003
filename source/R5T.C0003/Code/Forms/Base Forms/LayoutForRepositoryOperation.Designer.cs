namespace R5T.C0003.Forms
{
    partial class LayoutForRepositoryOperation
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
            this.MainGroupBox.Controls.Add(this.RepositoryNameTextBox);
            this.MainGroupBox.Controls.Add(this.RepositoryNameLabel);
            this.MainGroupBox.Controls.Add(this.GitHubOwnerLabel);
            this.MainGroupBox.Controls.Add(this.GitHubOwnerLabelLabel);
            this.MainGroupBox.Controls.Add(this.OwnerNameSelectorComboBox);
            this.MainGroupBox.Controls.Add(this.OwnerNameLabel);
            // 
            // RepositoryNameTextBox
            // 
            this.RepositoryNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepositoryNameTextBox.Location = new System.Drawing.Point(13, 69);
            this.RepositoryNameTextBox.Name = "RepositoryNameTextBox";
            this.RepositoryNameTextBox.Size = new System.Drawing.Size(257, 29);
            this.RepositoryNameTextBox.TabIndex = 1;
            // 
            // RepositoryNameLabel
            // 
            this.RepositoryNameLabel.AutoSize = true;
            this.RepositoryNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepositoryNameLabel.Location = new System.Drawing.Point(13, 45);
            this.RepositoryNameLabel.Name = "RepositoryNameLabel";
            this.RepositoryNameLabel.Size = new System.Drawing.Size(134, 21);
            this.RepositoryNameLabel.TabIndex = 10;
            this.RepositoryNameLabel.Text = "Repository Name:";
            // 
            // GitHubOwnerLabel
            // 
            this.GitHubOwnerLabel.AutoSize = true;
            this.GitHubOwnerLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubOwnerLabel.Location = new System.Drawing.Point(119, 177);
            this.GitHubOwnerLabel.Name = "GitHubOwnerLabel";
            this.GitHubOwnerLabel.Size = new System.Drawing.Size(16, 15);
            this.GitHubOwnerLabel.TabIndex = 9;
            this.GitHubOwnerLabel.Text = "...";
            // 
            // GitHubOwnerLabelLabel
            // 
            this.GitHubOwnerLabelLabel.AutoSize = true;
            this.GitHubOwnerLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubOwnerLabelLabel.Location = new System.Drawing.Point(27, 177);
            this.GitHubOwnerLabelLabel.Name = "GitHubOwnerLabelLabel";
            this.GitHubOwnerLabelLabel.Size = new System.Drawing.Size(86, 15);
            this.GitHubOwnerLabelLabel.TabIndex = 8;
            this.GitHubOwnerLabelLabel.Text = "GitHub Owner:";
            // 
            // OwnerNameSelectorComboBox
            // 
            this.OwnerNameSelectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OwnerNameSelectorComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerNameSelectorComboBox.FormattingEnabled = true;
            this.OwnerNameSelectorComboBox.Location = new System.Drawing.Point(13, 138);
            this.OwnerNameSelectorComboBox.Name = "OwnerNameSelectorComboBox";
            this.OwnerNameSelectorComboBox.Size = new System.Drawing.Size(257, 29);
            this.OwnerNameSelectorComboBox.TabIndex = 3;
            this.OwnerNameSelectorComboBox.SelectedValueChanged += new System.EventHandler(this.OwnerNameSelectorComboBox_SelectedValueChanged);
            // 
            // OwnerNameLabel
            // 
            this.OwnerNameLabel.AutoSize = true;
            this.OwnerNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OwnerNameLabel.Location = new System.Drawing.Point(13, 114);
            this.OwnerNameLabel.Name = "OwnerNameLabel";
            this.OwnerNameLabel.Size = new System.Drawing.Size(106, 21);
            this.OwnerNameLabel.TabIndex = 6;
            this.OwnerNameLabel.Text = "Owner Name:";
            // 
            // LayoutForRepositoryOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "LayoutForRepositoryOperation";
            this.Text = "LayoutForRepositoryOperation";
            this.Shown += new System.EventHandler(this.LayoutForRepositoryOperation_Shown);
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.TextBox RepositoryNameTextBox;
        private System.Windows.Forms.Label RepositoryNameLabel;
        private System.Windows.Forms.Label GitHubOwnerLabel;
        private System.Windows.Forms.Label GitHubOwnerLabelLabel;
        private System.Windows.Forms.ComboBox OwnerNameSelectorComboBox;
        private System.Windows.Forms.Label OwnerNameLabel;
    }
}