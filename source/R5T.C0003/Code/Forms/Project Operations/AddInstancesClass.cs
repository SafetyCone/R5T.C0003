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
    public partial class AddInstancesClass : LayoutForProjectOperation
    {
        public AddInstancesClass()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                await F0084.ProjectOperations.Instance.CreateInstancesClassInProject(
                    this.SelectProjectFileModel.ProjectFilePath);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(
                Internal);
        }
    }
}
