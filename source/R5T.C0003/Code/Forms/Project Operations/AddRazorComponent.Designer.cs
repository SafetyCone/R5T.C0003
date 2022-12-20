namespace R5T.C0003.Forms.Project
{
    partial class AddRazorComponent
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
            this.ComponentNameTextBox = new System.Windows.Forms.TextBox();
            this.ComponentNameLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.ComponentNameTextBox);
            this.MainGroupBox.Controls.Add(this.ComponentNameLabel);
            this.MainGroupBox.Text = "Add Razor Component";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ComponentNameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ComponentNameTextBox, 0);
            // 
            // ComponentNameTextBox
            // 
            this.ComponentNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComponentNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComponentNameTextBox.Location = new System.Drawing.Point(13, 192);
            this.ComponentNameTextBox.Name = "ComponentNameTextBox";
            this.ComponentNameTextBox.Size = new System.Drawing.Size(457, 29);
            this.ComponentNameTextBox.TabIndex = 22;
            // 
            // ComponentNameLabel
            // 
            this.ComponentNameLabel.AutoSize = true;
            this.ComponentNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ComponentNameLabel.Location = new System.Drawing.Point(13, 168);
            this.ComponentNameLabel.Name = "ComponentNameLabel";
            this.ComponentNameLabel.Size = new System.Drawing.Size(141, 21);
            this.ComponentNameLabel.TabIndex = 23;
            this.ComponentNameLabel.Text = "Component Name:";
            // 
            // AddRazorComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddRazorComponent";
            this.Text = "AddRazorComponent";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ComponentNameTextBox;
        protected System.Windows.Forms.Label ComponentNameLabel;
    }
}