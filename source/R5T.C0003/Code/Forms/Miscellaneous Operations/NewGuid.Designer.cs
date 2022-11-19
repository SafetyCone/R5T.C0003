namespace R5T.C0003.Forms.Miscellaneous
{
    partial class NewGuid
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
            this.CopyToClipboardButton = new System.Windows.Forms.Button();
            this.FormatGroupBox = new System.Windows.Forms.GroupBox();
            this.NLowerFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.DUpperRadioButton = new System.Windows.Forms.RadioButton();
            this.DLowerFormatRadioButton = new System.Windows.Forms.RadioButton();
            this.MainGroupBox.SuspendLayout();
            this.FormatGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.FormatGroupBox);
            this.MainGroupBox.Controls.Add(this.CopyToClipboardButton);
            this.MainGroupBox.Controls.Add(this.OutputTextBox);
            this.MainGroupBox.Controls.Add(this.RunButton);
            this.MainGroupBox.Text = "Generate New Guid";
            // 
            // RunButton
            // 
            this.RunButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RunButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RunButton.Location = new System.Drawing.Point(6, 38);
            this.RunButton.Name = "RunButton";
            this.RunButton.Size = new System.Drawing.Size(100, 39);
            this.RunButton.TabIndex = 1;
            this.RunButton.Text = "Run";
            this.RunButton.UseVisualStyleBackColor = true;
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // OutputTextBox
            // 
            this.OutputTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OutputTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OutputTextBox.Location = new System.Drawing.Point(13, 210);
            this.OutputTextBox.Name = "OutputTextBox";
            this.OutputTextBox.Size = new System.Drawing.Size(457, 29);
            this.OutputTextBox.TabIndex = 3;
            // 
            // CopyToClipboardButton
            // 
            this.CopyToClipboardButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CopyToClipboardButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CopyToClipboardButton.Location = new System.Drawing.Point(297, 245);
            this.CopyToClipboardButton.Name = "CopyToClipboardButton";
            this.CopyToClipboardButton.Size = new System.Drawing.Size(173, 39);
            this.CopyToClipboardButton.TabIndex = 4;
            this.CopyToClipboardButton.Text = "Copy to Clipboard";
            this.CopyToClipboardButton.UseVisualStyleBackColor = true;
            this.CopyToClipboardButton.Click += new System.EventHandler(this.CopyToClipboardButton_Click);
            // 
            // FormatGroupBox
            // 
            this.FormatGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FormatGroupBox.Controls.Add(this.NLowerFormatRadioButton);
            this.FormatGroupBox.Controls.Add(this.DUpperRadioButton);
            this.FormatGroupBox.Controls.Add(this.DLowerFormatRadioButton);
            this.FormatGroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormatGroupBox.Location = new System.Drawing.Point(6, 83);
            this.FormatGroupBox.Name = "FormatGroupBox";
            this.FormatGroupBox.Size = new System.Drawing.Size(464, 121);
            this.FormatGroupBox.TabIndex = 2;
            this.FormatGroupBox.TabStop = false;
            this.FormatGroupBox.Text = "Formats";
            // 
            // NLowerFormatRadioButton
            // 
            this.NLowerFormatRadioButton.AutoSize = true;
            this.NLowerFormatRadioButton.Location = new System.Drawing.Point(17, 78);
            this.NLowerFormatRadioButton.Name = "NLowerFormatRadioButton";
            this.NLowerFormatRadioButton.Size = new System.Drawing.Size(217, 19);
            this.NLowerFormatRadioButton.TabIndex = 3;
            this.NLowerFormatRadioButton.Text = "xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx";
            this.NLowerFormatRadioButton.UseVisualStyleBackColor = true;
            this.NLowerFormatRadioButton.CheckedChanged += new System.EventHandler(this.NLowerFormatRadioButton_CheckedChanged);
            // 
            // DUpperRadioButton
            // 
            this.DUpperRadioButton.AutoSize = true;
            this.DUpperRadioButton.Checked = true;
            this.DUpperRadioButton.Location = new System.Drawing.Point(17, 28);
            this.DUpperRadioButton.Name = "DUpperRadioButton";
            this.DUpperRadioButton.Size = new System.Drawing.Size(317, 19);
            this.DUpperRadioButton.TabIndex = 1;
            this.DUpperRadioButton.TabStop = true;
            this.DUpperRadioButton.Text = "XXXXXXXX-XXXX-XXXX-XXXX-XXXXXXXXXXXX (default)";
            this.DUpperRadioButton.UseVisualStyleBackColor = true;
            this.DUpperRadioButton.CheckedChanged += new System.EventHandler(this.DUpperRadioButton_CheckedChanged);
            // 
            // DLowerFormatRadioButton
            // 
            this.DLowerFormatRadioButton.AutoSize = true;
            this.DLowerFormatRadioButton.Location = new System.Drawing.Point(17, 53);
            this.DLowerFormatRadioButton.Name = "DLowerFormatRadioButton";
            this.DLowerFormatRadioButton.Size = new System.Drawing.Size(237, 19);
            this.DLowerFormatRadioButton.TabIndex = 2;
            this.DLowerFormatRadioButton.Text = "xxxxxxxx-xxxx-xxxx-xxxx-xxxxxxxxxxxx";
            this.DLowerFormatRadioButton.UseVisualStyleBackColor = true;
            this.DLowerFormatRadioButton.CheckedChanged += new System.EventHandler(this.DLowerFormatRadioButton_CheckedChanged);
            // 
            // NewGuid
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "NewGuid";
            this.Text = "NewGuid";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.FormatGroupBox.ResumeLayout(false);
            this.FormatGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Button RunButton;
        protected System.Windows.Forms.Button CopyToClipboardButton;
        private System.Windows.Forms.TextBox OutputTextBox;
        private System.Windows.Forms.GroupBox FormatGroupBox;
        private System.Windows.Forms.RadioButton DLowerFormatRadioButton;
        private System.Windows.Forms.RadioButton DUpperRadioButton;
        private System.Windows.Forms.RadioButton NLowerFormatRadioButton;
    }
}