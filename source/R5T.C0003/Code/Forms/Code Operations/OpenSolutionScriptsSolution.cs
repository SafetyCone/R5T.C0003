using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms.Code
{
    public partial class OpenSolutionScriptsSolution : LayoutForClickOperation
    {
        public OpenSolutionScriptsSolution()
        {
            InitializeComponent();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            Instances.TryOperator.TryOrShowMessage(() =>
            {
                Instances.Operations.OpenSolutionScriptsSolution();
            });
        }
    }
}
