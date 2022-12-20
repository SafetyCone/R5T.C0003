using System;


namespace R5T.C0003.Forms.Solution
{
    public partial class UpgradeToVS2022 : LayoutForSolutionOperation
    {
        public UpgradeToVS2022()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            await TryOperator.Instance.TryShowDoneOrExceptionMessage(
                () => Instances.SolutionFileOperations.UpgradeSolutionFile_ToVS2022(
                    this.SolutionFilePath));
        }
    }
}
