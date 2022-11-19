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
    public partial class RemoveExtraneousProjectReferences : LayoutForProjectOperation
    {
        public RemoveExtraneousProjectReferences()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                await Instances.ProjectOperations.RemoveExtraneousProjectReferencesFromAllRecursiveReferences(
                    this.SelectProjectFileModel.ProjectFilePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
