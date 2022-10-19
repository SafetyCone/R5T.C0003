namespace R5T.C0003.Forms.Repository
{
    partial class LayoutForCreateNewRepositoryOperation
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
            this.CreateButton = new System.Windows.Forms.Button();
            this.RemoteRepositoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.RemoteRepositoryLabelLabel = new System.Windows.Forms.Label();
            this.LocalLabelLabel = new System.Windows.Forms.Label();
            this.LocalRepositoryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.IsPrivateCheckBox = new System.Windows.Forms.CheckBox();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.IsPrivateCheckBox);
            this.MainGroupBox.Controls.Add(this.DescriptionTextBox);
            this.MainGroupBox.Controls.Add(this.DescriptionLabel);
            this.MainGroupBox.Controls.Add(this.LocalLabelLabel);
            this.MainGroupBox.Controls.Add(this.LocalRepositoryLinkLabel);
            this.MainGroupBox.Controls.Add(this.RemoteRepositoryLabelLabel);
            this.MainGroupBox.Controls.Add(this.RemoteRepositoryLinkLabel);
            this.MainGroupBox.Controls.Add(this.CreateButton);
            this.MainGroupBox.Controls.SetChildIndex(this.RepositoryNameTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.CreateButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RemoteRepositoryLinkLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RemoteRepositoryLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.LocalRepositoryLinkLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.LocalLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DescriptionTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.IsPrivateCheckBox, 0);
            // 
            // CreateButton
            // 
            this.CreateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CreateButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CreateButton.Location = new System.Drawing.Point(13, 282);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(100, 39);
            this.CreateButton.TabIndex = 5;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            // 
            // RemoteRepositoryLinkLabel
            // 
            this.RemoteRepositoryLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoteRepositoryLinkLabel.AutoSize = true;
            this.RemoteRepositoryLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoteRepositoryLinkLabel.Location = new System.Drawing.Point(81, 332);
            this.RemoteRepositoryLinkLabel.Name = "RemoteRepositoryLinkLabel";
            this.RemoteRepositoryLinkLabel.Size = new System.Drawing.Size(16, 15);
            this.RemoteRepositoryLinkLabel.TabIndex = 12;
            this.RemoteRepositoryLinkLabel.TabStop = true;
            this.RemoteRepositoryLinkLabel.Text = "...";
            this.RemoteRepositoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.RemoteRepositoryLinkLabel_LinkClicked);
            // 
            // RemoteRepositoryLabelLabel
            // 
            this.RemoteRepositoryLabelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RemoteRepositoryLabelLabel.AutoSize = true;
            this.RemoteRepositoryLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RemoteRepositoryLabelLabel.Location = new System.Drawing.Point(27, 332);
            this.RemoteRepositoryLabelLabel.Name = "RemoteRepositoryLabelLabel";
            this.RemoteRepositoryLabelLabel.Size = new System.Drawing.Size(48, 15);
            this.RemoteRepositoryLabelLabel.TabIndex = 13;
            this.RemoteRepositoryLabelLabel.Text = "GitHub:";
            // 
            // LocalLabelLabel
            // 
            this.LocalLabelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocalLabelLabel.AutoSize = true;
            this.LocalLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalLabelLabel.Location = new System.Drawing.Point(27, 353);
            this.LocalLabelLabel.Name = "LocalLabelLabel";
            this.LocalLabelLabel.Size = new System.Drawing.Size(38, 15);
            this.LocalLabelLabel.TabIndex = 15;
            this.LocalLabelLabel.Text = "Local:";
            // 
            // LocalRepositoryLinkLabel
            // 
            this.LocalRepositoryLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LocalRepositoryLinkLabel.AutoSize = true;
            this.LocalRepositoryLinkLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LocalRepositoryLinkLabel.Location = new System.Drawing.Point(81, 353);
            this.LocalRepositoryLinkLabel.Name = "LocalRepositoryLinkLabel";
            this.LocalRepositoryLinkLabel.Size = new System.Drawing.Size(16, 15);
            this.LocalRepositoryLinkLabel.TabIndex = 14;
            this.LocalRepositoryLinkLabel.TabStop = true;
            this.LocalRepositoryLinkLabel.Text = "...";
            this.LocalRepositoryLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LocalRepositoryLinkLabel_LinkClicked);
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(13, 231);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(457, 45);
            this.DescriptionTextBox.TabIndex = 4;
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 207);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(92, 21);
            this.DescriptionLabel.TabIndex = 17;
            this.DescriptionLabel.Text = "Description:";
            // 
            // IsPrivateCheckBox
            // 
            this.IsPrivateCheckBox.AutoSize = true;
            this.IsPrivateCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsPrivateCheckBox.Location = new System.Drawing.Point(288, 71);
            this.IsPrivateCheckBox.Name = "IsPrivateCheckBox";
            this.IsPrivateCheckBox.Size = new System.Drawing.Size(99, 25);
            this.IsPrivateCheckBox.TabIndex = 2;
            this.IsPrivateCheckBox.Text = "Is Private?";
            this.IsPrivateCheckBox.UseVisualStyleBackColor = true;
            // 
            // LayoutForCreateNewRepositoryOperation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "LayoutForCreateNewRepositoryOperation";
            this.Text = "NewLibrary";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button CreateButton;
        private System.Windows.Forms.Label LocalLabelLabel;
        private System.Windows.Forms.LinkLabel LocalRepositoryLinkLabel;
        private System.Windows.Forms.Label RemoteRepositoryLabelLabel;
        private System.Windows.Forms.LinkLabel RemoteRepositoryLinkLabel;
        protected System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.CheckBox IsPrivateCheckBox;
    }
}