using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0062.Extensions;


namespace R5T.C0003.Forms
{
    public partial class LayoutForProjectOperation : LayoutForOperation
    {
        protected string ProjectFilePath { get; set; }


        public LayoutForProjectOperation()
        {
            InitializeComponent();
        }

        private void SelectProjectFileButton_Click(object sender, EventArgs e)
        {
            // Ignore the result.
            this.ProjectFileOpenFileDialog.ShowDialog();

            this.ProjectFilePathTextBox.Text = this.ProjectFileOpenFileDialog.FileName;
        }

        private void ProjectFilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            this.ProjectFilePath = this.ProjectFilePathTextBox.Text;

            var fileExists = Instances.FileSystemOperator.FileExists(
                this.ProjectFilePath);

            this.FileExistsLabel.SetTrueOrFalse(fileExists);

            if(!fileExists)
            {
                this.IsProjectFileLabel.Reset();

                return;
            }

            var isProjectFile = Instances.ProjectFileOperator.IsProjectFile(
                this.ProjectFilePath);

            this.IsProjectFileLabel.SetTrueOrFalse(isProjectFile);
        }
    }
}
