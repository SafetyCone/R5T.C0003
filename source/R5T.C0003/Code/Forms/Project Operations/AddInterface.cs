using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using R5T.F0062;
using R5T.F0089;


namespace R5T.C0003.Forms.Project
{
    public partial class AddInterface : LayoutForProjectOperation
    {
        private string InterfaceName
        {
            get
            {
                var className = TextBoxOperator.Instance.Get_Value(
                    this.InterfaceNameTextBox);

                return className;
            }
        }


        public AddInterface()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                var interfaceContext = CodeFileContextOperations.Instance.GetInterfaceTypeContext(
                    this.SelectProjectFileModel.ProjectFilePath,
                    this.InterfaceName);

                await F0084.ProjectOperations.Instance.CreateInterfaceInProject(interfaceContext);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
