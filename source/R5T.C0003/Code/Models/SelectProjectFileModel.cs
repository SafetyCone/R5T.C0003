using System;
using System.Windows.Forms;

using R5T.F0062.Extensions;


namespace R5T.C0003
{
    public class SelectProjectFileModel : IDisposable
    {
        #region Disposable

        private bool Disposed = false;


        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if(!this.Disposed)
            {
                if(disposing)
                {
                    this.SelectProjectFileButton.Click -= this.SelectProjectFileButton_ClickHandler;
                    this.ProjectFilePathTextBox.TextChanged -= this.ProjectFilePathTextBox_TextChanged;
                }

                this.Disposed = true;
            }
        }

        ~SelectProjectFileModel()
        {
            this.Dispose(disposing: false);
        }

        #endregion

        public string ProjectFilePath { get; set; }

        public Button SelectProjectFileButton { get; }
        public TextBox ProjectFilePathTextBox { get; }
        public Label FileExistsLabel { get; }
        public Label IsProjectFileLabel { get; }


        public SelectProjectFileModel(
            Button selectProjectFileButton,
            TextBox projectFilePathTextBox,
            Label fileExistsLabel,
            Label isProjectFileLabel)
        {
            this.SelectProjectFileButton = selectProjectFileButton;
            this.ProjectFilePathTextBox = projectFilePathTextBox;
            this.FileExistsLabel = fileExistsLabel;
            this.IsProjectFileLabel = isProjectFileLabel;

            this.SelectProjectFileButton.Click += this.SelectProjectFileButton_ClickHandler;
            this.ProjectFilePathTextBox.TextChanged += this.ProjectFilePathTextBox_TextChanged;
        }

        public void SelectProjectFileButton_ClickHandler(object sender, EventArgs eventArgs)
        {
            var projectFileOpenFileDialog = new OpenFileDialog()
            {
                Title = "Select C# Project File",
                Filter = "C# Project Files (*.csproj)|*.csproj"
            };

            // Ignore the result.
            var dialogResult = projectFileOpenFileDialog.ShowDialog();

            if(dialogResult == DialogResult.OK && projectFileOpenFileDialog.FileName.IsNotNullAndNotEmpty())
            {
                this.ProjectFilePathTextBox.Text = projectFileOpenFileDialog.FileName;
            }
        }

        public void ProjectFilePathTextBox_TextChanged(object sender, EventArgs eventArgs)
        {
            this.ProjectFilePath = this.ProjectFilePathTextBox.Text;

            var fileExists = Instances.FileSystemOperator.FileExists(
                this.ProjectFilePath);

            this.FileExistsLabel.SetTrueOrFalse(fileExists);

            if (!fileExists)
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
