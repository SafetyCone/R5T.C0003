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
    public partial class AddWinForm : LayoutForProjectOperation
    {
        private string FormName
        {
            get
            {
                var output = F0062.TextBoxOperator.Instance.Get_Value(
                    this.FormNameTextBox);

                return output;
            }
        }


        public AddWinForm()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                await F0084.ProjectOperations.Instance.CreateWinFormInProject(
                    this.SelectProjectFileModel.ProjectFilePath,
                    this.FormName);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
