using System;
using System.Threading.Tasks;


namespace R5T.C0003.Forms.Project
{
    public partial class GenerateAllTailwindCssContentPathsFile : LayoutForProjectOperation
    {
        public GenerateAllTailwindCssContentPathsFile()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                await Instances.Operations.GenerateAllTailwindContentPathsJsonFile(
                    this.SelectProjectFileModel.ProjectFilePath);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
