namespace R5T.C0003.Forms
{
    partial class About
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
            this.TitleGroupBox = new System.Windows.Forms.GroupBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.ExitButton = new System.Windows.Forms.Button();
            this.InformationGroupBox = new System.Windows.Forms.GroupBox();
            this.VersionValueLabel = new System.Windows.Forms.Label();
            this.VersionLabelLabel = new System.Windows.Forms.Label();
            this.TitleGroupBox.SuspendLayout();
            this.InformationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleGroupBox
            // 
            this.TitleGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TitleGroupBox.Controls.Add(this.DescriptionTextBox);
            this.TitleGroupBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitleGroupBox.Location = new System.Drawing.Point(12, 12);
            this.TitleGroupBox.Name = "TitleGroupBox";
            this.TitleGroupBox.Size = new System.Drawing.Size(516, 272);
            this.TitleGroupBox.TabIndex = 3;
            this.TitleGroupBox.TabStop = false;
            this.TitleGroupBox.Text = "Ithaca";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.DescriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(6, 38);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ReadOnly = true;
            this.DescriptionTextBox.Size = new System.Drawing.Size(486, 214);
            this.DescriptionTextBox.TabIndex = 3;
            this.DescriptionTextBox.Text = "Ithaca is a TreeView of all operations on:\r\n\r\n* Repository\r\n* Solution\r\n* Project" +
    "\r\n* Code file, and\r\n* Code operations.\r\n\r\n\r\nIthaca makes it quick and easy to se" +
    "lect files and run operations.\r\n\r\n";
            // 
            // ExitButton
            // 
            this.ExitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ExitButton.Location = new System.Drawing.Point(421, 399);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(107, 42);
            this.ExitButton.TabIndex = 0;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // InformationGroupBox
            // 
            this.InformationGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InformationGroupBox.Controls.Add(this.VersionValueLabel);
            this.InformationGroupBox.Controls.Add(this.VersionLabelLabel);
            this.InformationGroupBox.Location = new System.Drawing.Point(12, 290);
            this.InformationGroupBox.Name = "InformationGroupBox";
            this.InformationGroupBox.Size = new System.Drawing.Size(516, 103);
            this.InformationGroupBox.TabIndex = 5;
            this.InformationGroupBox.TabStop = false;
            this.InformationGroupBox.Text = "Information";
            // 
            // VersionValueLabel
            // 
            this.VersionValueLabel.AutoSize = true;
            this.VersionValueLabel.Location = new System.Drawing.Point(60, 19);
            this.VersionValueLabel.Name = "VersionValueLabel";
            this.VersionValueLabel.Size = new System.Drawing.Size(31, 15);
            this.VersionValueLabel.TabIndex = 1;
            this.VersionValueLabel.Text = "1.0.0";
            // 
            // VersionLabelLabel
            // 
            this.VersionLabelLabel.AutoSize = true;
            this.VersionLabelLabel.Location = new System.Drawing.Point(6, 19);
            this.VersionLabelLabel.Name = "VersionLabelLabel";
            this.VersionLabelLabel.Size = new System.Drawing.Size(48, 15);
            this.VersionLabelLabel.TabIndex = 0;
            this.VersionLabelLabel.Text = "Version:";
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 453);
            this.ControlBox = false;
            this.Controls.Add(this.InformationGroupBox);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.TitleGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "About";
            this.Text = "Ithaca-About";
            this.TitleGroupBox.ResumeLayout(false);
            this.TitleGroupBox.PerformLayout();
            this.InformationGroupBox.ResumeLayout(false);
            this.InformationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TitleGroupBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.GroupBox InformationGroupBox;
        private System.Windows.Forms.Label VersionValueLabel;
        private System.Windows.Forms.Label VersionLabelLabel;
    }
}