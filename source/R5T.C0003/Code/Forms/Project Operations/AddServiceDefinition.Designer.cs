namespace R5T.C0003.Forms.Project
{
    partial class AddServiceDefinition
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
            this.ServiceNameStemTextBox = new System.Windows.Forms.TextBox();
            this.ServiceDefinitionNameLabel = new System.Windows.Forms.Label();
            this.ActualServiceNameLabel = new System.Windows.Forms.Label();
            this.ActualServiceNameLabelLabel = new System.Windows.Forms.Label();
            this.MainGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // RunButton
            // 
            this.RunButton.Click += new System.EventHandler(this.RunButton_Click);
            // 
            // MainGroupBox
            // 
            this.MainGroupBox.Controls.Add(this.ActualServiceNameLabel);
            this.MainGroupBox.Controls.Add(this.ActualServiceNameLabelLabel);
            this.MainGroupBox.Controls.Add(this.ServiceNameStemTextBox);
            this.MainGroupBox.Controls.Add(this.ServiceDefinitionNameLabel);
            this.MainGroupBox.Text = "Add Service Definition";
            this.MainGroupBox.Controls.SetChildIndex(this.ProjectFilePathLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.RunButton, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ServiceDefinitionNameLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ServiceNameStemTextBox, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ActualServiceNameLabelLabel, 0);
            this.MainGroupBox.Controls.SetChildIndex(this.ActualServiceNameLabel, 0);
            // 
            // ServiceNameStemTextBox
            // 
            this.ServiceNameStemTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServiceNameStemTextBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServiceNameStemTextBox.Location = new System.Drawing.Point(13, 189);
            this.ServiceNameStemTextBox.Name = "ServiceNameStemTextBox";
            this.ServiceNameStemTextBox.Size = new System.Drawing.Size(457, 29);
            this.ServiceNameStemTextBox.TabIndex = 20;
            this.ServiceNameStemTextBox.Text = "ExampleService";
            // 
            // ServiceDefinitionNameLabel
            // 
            this.ServiceDefinitionNameLabel.AutoSize = true;
            this.ServiceDefinitionNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ServiceDefinitionNameLabel.Location = new System.Drawing.Point(13, 165);
            this.ServiceDefinitionNameLabel.Name = "ServiceDefinitionNameLabel";
            this.ServiceDefinitionNameLabel.Size = new System.Drawing.Size(181, 21);
            this.ServiceDefinitionNameLabel.TabIndex = 21;
            this.ServiceDefinitionNameLabel.Text = "Service Definition Name:";
            // 
            // ActualServiceNameLabel
            // 
            this.ActualServiceNameLabel.AutoSize = true;
            this.ActualServiceNameLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualServiceNameLabel.Location = new System.Drawing.Point(132, 233);
            this.ActualServiceNameLabel.Name = "ActualServiceNameLabel";
            this.ActualServiceNameLabel.Size = new System.Drawing.Size(16, 15);
            this.ActualServiceNameLabel.TabIndex = 23;
            this.ActualServiceNameLabel.Text = "...";
            // 
            // ActualServiceNameLabelLabel
            // 
            this.ActualServiceNameLabelLabel.AutoSize = true;
            this.ActualServiceNameLabelLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActualServiceNameLabelLabel.Location = new System.Drawing.Point(26, 233);
            this.ActualServiceNameLabelLabel.Name = "ActualServiceNameLabelLabel";
            this.ActualServiceNameLabelLabel.Size = new System.Drawing.Size(79, 15);
            this.ActualServiceNameLabelLabel.TabIndex = 22;
            this.ActualServiceNameLabelLabel.Text = "Actual Name:";
            // 
            // AddServiceDefinition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 400);
            this.Name = "AddServiceDefinition";
            this.Text = "AddServiceDefinition";
            this.MainGroupBox.ResumeLayout(false);
            this.MainGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox ServiceNameStemTextBox;
        private System.Windows.Forms.Label ServiceDefinitionNameLabel;
        private System.Windows.Forms.Label ActualServiceNameLabel;
        private System.Windows.Forms.Label ActualServiceNameLabelLabel;
    }
}