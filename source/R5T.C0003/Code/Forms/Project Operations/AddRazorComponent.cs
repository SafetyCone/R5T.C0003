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
    public partial class AddRazorComponent : LayoutForProjectOperation
    {
        public string ComponentName
        {
            get
            {
                var componentName = F0062.TextBoxOperator.Instance.Get_Value(
                    this.ComponentNameTextBox);

                return componentName;
            }
        }

        public AddRazorComponent()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                await F0084.ProjectOperations.Instance.CreateRazorComponentInProject(
                    this.SelectProjectFileModel.ProjectFilePath,
                    this.ComponentName);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(
                Internal);
        }
    }
}
