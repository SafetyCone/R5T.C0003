using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0062;
using R5T.F0089;


namespace R5T.C0003.Forms.Project
{
    public partial class AddClass : LayoutForProjectOperation
    {
        private string ClassName
        {
            get
            {
                var className = TextBoxOperator.Instance.Get_Value(
                    this.ClassNameTextBox);

                return className;
            }
        }


        public AddClass()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            async Task Internal()
            {
                var classContext = CodeFileContextOperations.Instance.GetClassTypeContext(
                    this.SelectProjectFileModel.ProjectFilePath,
                    this.ClassName);

                await F0084.ProjectOperations.Instance.CreateClassInProject(classContext);
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
