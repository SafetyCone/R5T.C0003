using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms
{
    public partial class LayoutForProjectOperation : LayoutForOperation
    {
        protected SelectProjectFileModel SelectProjectFileModel { get; }


        public LayoutForProjectOperation()
        {
            InitializeComponent();

            this.SelectProjectFileModel = new SelectProjectFileModel(
                this.SelectProjectFileButton,
                this.ProjectFilePathTextBox,
                this.FileExistsLabel,
                this.IsProjectFileLabel);
        }
    }
}
