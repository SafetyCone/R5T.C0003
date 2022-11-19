namespace R5T.C0003.Forms.AWS.S3
{
    partial class GenerateBucketName
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
            this.RunButton = new System.Windows.Forms.Button();
            this.OutputTextBox = new System.Windows.Forms.TextBox();
            this.OutputTextBoxLabel = new System.Windows.Forms.Label();
            this.IsPublicCheckBox = new System.Windows.Forms.CheckBox();
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.CopyToClipboardButton);
            this.MainGroupBox.Controls.Add(this.IsPublicCheckBox);
            this.MainGroupBox.Controls.Add(this.OutputTextBoxLabel);
            this.MainGroupBox.Controls.Add(this.OutputTextBox);
            this.MainGroupBox.Controls.Add(this.RunButton);
            this.MainGroupBox.Text = "Generate S3 Bucket Name";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(6, 94);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 39);
            this.RunButton.TabIndex = 2;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextBox.Location = new System.Drawing.Point(6, 186);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(464, 29);
            this.OutputTextBox.TabIndex = 3;
            // 
            // OutputTextBoxLabel
            // 
            this.OutputTextBoxLabel.AutoSize = true;
            this.OutputTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextBoxLabel.Location = new System.Drawing.Point(6, 168);
            this.OutputTextBoxLabel.Name = "OutputTextBoxLabel";
            this.OutputTextBoxLabel.Size = new System.Drawing.Size(96, 15);
            this.OutputTextBoxLabel.TabIndex = 22;
            this.OutputTextBoxLabel.Text = "S3 Bucket Name:";
            // 
            // IsPublicCheckBox
            // 
            this.IsPublicCheckBox.AutoSize = true;
            this.IsPublicCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsPublicCheckBox.Location = new System.Drawing.Point(22, 47);
            this.IsPublicCheckBox.Name = "IsPublicCheckBox";
            this.IsPublicCheckBox.Size = new System.Drawing.Size(93, 25);
            this.IsPublicCheckBox.TabIndex = 1;
            this.IsPublicCheckBox.Text = "Is Public?";
            this.IsPublicCheckBox.UseVisualStyleBackColor = true;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToClipboardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyToClipboardButton.Location = new System.Drawing.Point(6, 221);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(202, 39);
            this.CopyToClipboardButton.TabIndex = 23;
            this.CopyToClipboardButton.Text = "Copy To Clipboard";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // GenerateBucketName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "GenerateBucketName";
            this.Text = "GenerateBucketName";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OutputTextBox;
        protected System.Windows.Forms.Button RunButton;
        private System.Windows.Forms.CheckBox IsPublicCheckBox;
        private System.Windows.Forms.Label OutputTextBoxLabel;
        protected System.Windows.Forms.Button CopyToClipboardButton;
    }
}