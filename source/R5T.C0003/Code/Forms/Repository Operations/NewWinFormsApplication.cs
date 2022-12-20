using System;

using Microsoft.Extensions.Logging;


namespace R5T.C0003.Forms.Repository
{
    public partial class NewWinFormsApplication : LayoutForCreateNewRepositoryOperation
    {
        private ILogger Logger { get; }


        public NewWinFormsApplication(
            ILogger<NewWinFormsApplication> logger)
        {
            InitializeComponent();

            this.Logger = logger;
        }

        private async void CreateButton_Click(object sender, EventArgs e)
        {
            await this.CreateRepository(
                F0093.RepositoryOperations.Instance.CreateRepository_WinFormsApplication,
                this.Logger);
        }
    }
}
