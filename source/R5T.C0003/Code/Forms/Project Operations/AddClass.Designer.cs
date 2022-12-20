namespace R5T.C0003.Forms.Project
{
    partial class AddClass
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
            this.ClassNameTextBox = new System.Windows.Forms.TextBox();
            this.ClassNameLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.ClassNameTextBox);
            this.MainGroupBox.Controls.Add(this.ClassNameLabel);
            this.MainGroupBox.Text = "Add Class";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ClassNameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ClassNameTextBox, 0);
            // 
            // ClassNameTextBox
            // 
            this.ClassNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClassNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassNameTextBox.Location = new System.Drawing.Point(13, 191);
            this.ClassNameTextBox.Name = "ClassNameTextBox";
            this.ClassNameTextBox.Size = new System.Drawing.Size(457, 29);
            this.ClassNameTextBox.TabIndex = 20;
            // 
            // ClassNameLabel
            // 
            this.ClassNameLabel.AutoSize = true;
            this.ClassNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ClassNameLabel.Location = new System.Drawing.Point(13, 167);
            this.ClassNameLabel.Name = "ClassNameLabel";
            this.ClassNameLabel.Size = new System.Drawing.Size(95, 21);
            this.ClassNameLabel.TabIndex = 21;
            this.ClassNameLabel.Text = "Class Name:";
            // 
            // AddClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddClass";
            this.Text = "AddClass";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ClassNameTextBox;
        protected System.Windows.Forms.Label ClassNameLabel;
    }
}