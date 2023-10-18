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
    public partial class LayoutForSolutionOperation : LayoutForOperation
    {
        protected string SolutionFilePath { get; set; }


        public LayoutForSolutionOperation()
        {
            InitializeComponent();
        }

        private void SelectSolutionFileButton_Click(object sender, EventArgs e)
        {
            // Ignore the result.
            this.SolutionFileOpenFileDialog.ShowDialog();

            this.SolutionFilePathTextBox.Text = this.SolutionFileOpenFileDialog.FileName;
        }

        private void SolutionFilePathTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SolutionFilePath = this.SolutionFilePathTextBox.Text;

            var fileExists = Instances.FileSystemOperator.Exists_File(
                this.SolutionFilePath);

            this.FileExistsLabel.SetTrueOrFalse(fileExists);

            if(!fileExists)
            {
                this.IsSolutionFileLabel.Reset();

                return;
            }

            var isSolutionFile = Instances.SolutionFileOperator.IsSolutionFile(
                this.SolutionFilePath);

            this.IsSolutionFileLabel.SetTrueOrFalse(isSolutionFile);
        }
    }
}
