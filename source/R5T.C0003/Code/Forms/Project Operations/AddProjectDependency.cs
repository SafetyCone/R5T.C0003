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
    public partial class AddProjectDependency : LayoutForProjectOperation
    {
        protected SelectProjectFileModel SelectDependencyProjectFileModel { get; }


        public AddProjectDependency()
        {
            InitializeComponent();

            this.SelectDependencyProjectFileModel = new SelectProjectFileModel(
                this.SelectDependencyProjectFileButton,
                this.DependencyProjectFilePathTextBox,
                this.DependencyFileExistsLabel,
                this.DependencyIsProjectFileLabel);
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                await F0056.ProjectOperations.Instance.AddProjectReference_AndUpdateSolutions(
                    this.SelectProjectFileModel.ProjectFilePath,
                    this.SelectDependencyProjectFileModel.ProjectFilePath);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
