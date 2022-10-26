using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms.Project
{
    public sealed partial class ListDependencyChains : LayoutForProjectOperation
    {
        private SelectProjectFileModel DependencySelectProjectFileModel { get; }


        public ListDependencyChains()
        {
            InitializeComponent();

            this.DependencySelectProjectFileModel = new SelectProjectFileModel(
                this.SelectDependencyProjectFileButton,
                this.DependencyProjectFilePathTextBox,
                this.DependencyFileExistsLabel,
                this.IsProjectDependencyFileLabel);
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                var rootProjectFilePath = this.SelectProjectFileModel.ProjectFilePath;
                var dependencyProjectFilePath = this.DependencySelectProjectFileModel.ProjectFilePath;

                await Instances.ProjectOperations.ListProjectDependencyChains_ToFile(
                    rootProjectFilePath,
                    dependencyProjectFilePath);

                // No need for a done message since there will be a notepad output.
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
