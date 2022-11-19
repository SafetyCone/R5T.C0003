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
    public partial class IdentifyExtraneousProjectReferences : LayoutForProjectOperation
    {
        public IdentifyExtraneousProjectReferences()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                await Instances.ProjectOperations.OutputOnlyExtraneousProjectReferences(
                    this.SelectProjectFileModel.ProjectFilePath);

                MessageBox.Show("Done");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
