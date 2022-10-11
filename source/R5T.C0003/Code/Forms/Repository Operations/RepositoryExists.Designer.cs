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
            this.GitHubRepositoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.ResultLabelLabel = new System.Windows.Forms.Label();
            this.CheckExistsButton = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.GitHubRepositoryLinkLabel);
            this.MainGroupBox.Controls.Add(this.ResultLabel);
            this.MainGroupBox.Controls.Add(this.ResultLabelLabel);
            this.MainGroupBox.Controls.Add(this.CheckExistsButton);
            this.MainGroupBox.Text = "GitHub Repository Exists";
            this.MainGroupBox.Controls.SetChildIndex(this.RepositoryNameTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.CheckExistsButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ResultLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ResultLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.GitHubRepositoryLinkLabel, 0);
            // 
            // GitHubRepositoryLinkLabel
            // 
            this.GitHubRepositoryLinkLabel.AutoSize = true;
            this.GitHubRepositoryLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GitHubRepositoryLinkLabel.Location = new System.Drawing.Point(41, 335);
            this.GitHubRepositoryLinkLabel.Name = "GitHubRepositoryLinkLabel";
            this.GitHubRepositoryLinkLabel.Size = new System.Drawing.Size(56, 15);
            this.GitHubRepositoryLinkLabel.TabIndex = 12;
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
            this.ResultLabel.TabIndex = 14;
            this.ResultLabel.Text = "...";
            // 
            // ResultLabelLabel
            // 
            this.ResultLabelLabel.AutoSize = true;
            this.ResultLabelLabel.Location = new System.Drawing.Point(13, 295);
            this.ResultLabelLabel.Name = "ResultLabelLabel";
            this.ResultLabelLabel.Size = new System.Drawing.Size(83, 32);
            this.ResultLabelLabel.TabIndex = 13;
            this.ResultLabelLabel.Text = "Result:";
            // 
            // CheckExistsButton
            // 
            this.CheckExistsButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckExistsButton.Location = new System.Drawing.Point(13, 228);
            this.CheckExistsButton.Name = "CheckExistsButton";
            this.CheckExistsButton.Size = new System.Drawing.Size(102, 39);
            this.CheckExistsButton.TabIndex = 11;
            this.CheckExistsButton.Text = "Check";
            this.CheckExistsButton.UseVisualStyleBackColor = true;
            this.CheckExistsButton.Click += new System.EventHandler(this.CheckExistsButton_Click);
            // 
            // RepositoryExists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "RepositoryExists";
            this.Text = "RepositoryExists";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.LinkLabel GitHubRepositoryLinkLabel;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Label ResultLabelLabel;
        private System.Windows.Forms.Button CheckExistsButton;
    }
}