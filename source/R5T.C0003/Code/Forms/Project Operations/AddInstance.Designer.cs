namespace R5T.C0003.Forms.Project
{
    partial class AddInstance
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
            this.InstanceTypeLabel = new System.Windows.Forms.Label();
            this.InstanceTypeComboBox = new System.Windows.Forms.ComboBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.NameTextBox);
            this.MainGroupBox.Controls.Add(this.NameLabel);
            this.MainGroupBox.Controls.Add(this.InstanceTypeComboBox);
            this.MainGroupBox.Controls.Add(this.InstanceTypeLabel);
            this.MainGroupBox.Text = "Add Instance";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.InstanceTypeLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.InstanceTypeComboBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.NameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.NameTextBox, 0);
            // 
            // InstanceTypeLabel
            // 
            this.InstanceTypeLabel.AutoSize = true;
            this.InstanceTypeLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstanceTypeLabel.Location = new System.Drawing.Point(13, 164);
            this.InstanceTypeLabel.Name = "InstanceTypeLabel";
            this.InstanceTypeLabel.Size = new System.Drawing.Size(106, 21);
            this.InstanceTypeLabel.TabIndex = 20;
            this.InstanceTypeLabel.Text = "Instance Type:";
            // 
            // InstanceTypeComboBox
            // 
            this.InstanceTypeComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstanceTypeComboBox.FormattingEnabled = true;
            this.InstanceTypeComboBox.Location = new System.Drawing.Point(13, 188);
            this.InstanceTypeComboBox.Name = "InstanceTypeComboBox";
            this.InstanceTypeComboBox.Size = new System.Drawing.Size(245, 29);
            this.InstanceTypeComboBox.TabIndex = 21;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.Location = new System.Drawing.Point(13, 234);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(116, 21);
            this.NameLabel.TabIndex = 22;
            this.NameLabel.Text = "Instance Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameTextBox.Location = new System.Drawing.Point(13, 258);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(457, 29);
            this.NameTextBox.TabIndex = 23;
            // 
            // AddInstance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddInstance";
            this.Text = "AddInstance";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label InstanceTypeLabel;
        protected System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ComboBox InstanceTypeComboBox;
        private System.Windows.Forms.TextBox NameTextBox;
    }
}