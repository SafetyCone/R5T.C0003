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
    public partial class UpdateAddXMethods : LayoutForProjectOperation
    {
        public UpdateAddXMethods()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                Instances.CodeFileOperations.CreateAddXMethods_ForProject(
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
