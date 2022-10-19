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
    public partial class ListRecursiveDependencies : LayoutForProjectOperation
    {
        public ListRecursiveDependencies()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            await Instances.ProjectOperations.ListRecursiveProjectReferences_ToFile(
                this.ProjectFilePath);
        }
    }
}
