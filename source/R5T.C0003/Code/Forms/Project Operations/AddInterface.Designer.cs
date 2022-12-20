namespace R5T.C0003.Forms.Project
{
    partial class AddInterface
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
            this.InterfaceNameTextBox = new System.Windows.Forms.TextBox();
            this.InterfaceNameLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.InterfaceNameTextBox);
            this.MainGroupBox.Controls.Add(this.InterfaceNameLabel);
            this.MainGroupBox.Text = "Add Interface";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.InterfaceNameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.InterfaceNameTextBox, 0);
            // 
            // InterfaceNameTextBox
            // 
            this.InterfaceNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InterfaceNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InterfaceNameTextBox.Location = new System.Drawing.Point(13, 191);
            this.InterfaceNameTextBox.Name = "InterfaceNameTextBox";
            this.InterfaceNameTextBox.Size = new System.Drawing.Size(457, 29);
            this.InterfaceNameTextBox.TabIndex = 20;
            // 
            // InterfaceNameLabel
            // 
            this.InterfaceNameLabel.AutoSize = true;
            this.InterfaceNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InterfaceNameLabel.Location = new System.Drawing.Point(13, 167);
            this.InterfaceNameLabel.Name = "InterfaceNameLabel";
            this.InterfaceNameLabel.Size = new System.Drawing.Size(119, 21);
            this.InterfaceNameLabel.TabIndex = 21;
            this.InterfaceNameLabel.Text = "Interface Name:";
            // 
            // AddInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddInterface";
            this.Text = "AddClass";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox InterfaceNameTextBox;
        protected System.Windows.Forms.Label InterfaceNameLabel;
    }
}