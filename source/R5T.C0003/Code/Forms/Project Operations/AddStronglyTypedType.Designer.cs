namespace R5T.C0003.Forms.Project
{
    partial class AddStronglyTypedType
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
            this.BaseTypeSelectionComboBox = new System.Windows.Forms.ComboBox();
            this.TypeNameTextBox = new System.Windows.Forms.TextBox();
            this.BaseTypeSelectorLabel = new System.Windows.Forms.Label();
            this.TypeNameLabel = new System.Windows.Forms.Label();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.IsDraftCheckBox = new System.Windows.Forms.CheckBox();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.IsDraftCheckBox);
            this.MainGroupBox.Controls.Add(this.DescriptionLabel);
            this.MainGroupBox.Controls.Add(this.DescriptionTextBox);
            this.MainGroupBox.Controls.Add(this.TypeNameLabel);
            this.MainGroupBox.Controls.Add(this.BaseTypeSelectorLabel);
            this.MainGroupBox.Controls.Add(this.TypeNameTextBox);
            this.MainGroupBox.Controls.Add(this.BaseTypeSelectionComboBox);
            this.MainGroupBox.Text = "Add Strongly Typed Type";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.BaseTypeSelectionComboBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.TypeNameTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.BaseTypeSelectorLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.TypeNameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DescriptionTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.DescriptionLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.IsDraftCheckBox, 0);
            // 
            // BaseTypeSelectionComboBox
            // 
            this.BaseTypeSelectionComboBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseTypeSelectionComboBox.FormattingEnabled = true;
            this.BaseTypeSelectionComboBox.Items.AddRange(new object[] {
            "TypedDouble",
            "TypedGuid",
            "TypedInteger",
            "TypedString"});
            this.BaseTypeSelectionComboBox.Location = new System.Drawing.Point(13, 184);
            this.BaseTypeSelectionComboBox.Name = "BaseTypeSelectionComboBox";
            this.BaseTypeSelectionComboBox.Size = new System.Drawing.Size(191, 29);
            this.BaseTypeSelectionComboBox.TabIndex = 20;
            // 
            // TypeNameTextBox
            // 
            this.TypeNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TypeNameTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeNameTextBox.Location = new System.Drawing.Point(13, 240);
            this.TypeNameTextBox.Name = "TypeNameTextBox";
            this.TypeNameTextBox.PlaceholderText = "Type...";
            this.TypeNameTextBox.Size = new System.Drawing.Size(457, 29);
            this.TypeNameTextBox.TabIndex = 21;
            // 
            // BaseTypeSelectorLabel
            // 
            this.BaseTypeSelectorLabel.AutoSize = true;
            this.BaseTypeSelectorLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BaseTypeSelectorLabel.Location = new System.Drawing.Point(13, 160);
            this.BaseTypeSelectorLabel.Name = "BaseTypeSelectorLabel";
            this.BaseTypeSelectorLabel.Size = new System.Drawing.Size(81, 21);
            this.BaseTypeSelectorLabel.TabIndex = 22;
            this.BaseTypeSelectorLabel.Text = "Base Type:";
            // 
            // TypeNameLabel
            // 
            this.TypeNameLabel.AutoSize = true;
            this.TypeNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TypeNameLabel.Location = new System.Drawing.Point(13, 216);
            this.TypeNameLabel.Name = "TypeNameLabel";
            this.TypeNameLabel.Size = new System.Drawing.Size(91, 21);
            this.TypeNameLabel.TabIndex = 23;
            this.TypeNameLabel.Text = "Type Name:";
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.AutoSize = true;
            this.DescriptionLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionLabel.Location = new System.Drawing.Point(13, 272);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(92, 21);
            this.DescriptionLabel.TabIndex = 25;
            this.DescriptionLabel.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DescriptionTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DescriptionTextBox.Location = new System.Drawing.Point(13, 296);
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.PlaceholderText = "description...";
            this.DescriptionTextBox.Size = new System.Drawing.Size(457, 29);
            this.DescriptionTextBox.TabIndex = 24;
            // 
            // IsDraftCheckBox
            // 
            this.IsDraftCheckBox.AutoSize = true;
            this.IsDraftCheckBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IsDraftCheckBox.Location = new System.Drawing.Point(233, 187);
            this.IsDraftCheckBox.Name = "IsDraftCheckBox";
            this.IsDraftCheckBox.Size = new System.Drawing.Size(86, 25);
            this.IsDraftCheckBox.TabIndex = 26;
            this.IsDraftCheckBox.Text = "Is Draft?";
            this.IsDraftCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddStronglyTypedType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddStronglyTypedType";
            this.Text = "AddStronglyTypedType";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox BaseTypeSelectionComboBox;
        private System.Windows.Forms.TextBox TypeNameTextBox;
        protected System.Windows.Forms.Label TypeNameLabel;
        protected System.Windows.Forms.Label BaseTypeSelectorLabel;
        protected System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.CheckBox IsDraftCheckBox;
    }
}