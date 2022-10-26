using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace R5T.C0003.Forms.Solution
{
    public partial class RemoveExtraneousDependencies : LayoutForSolutionOperation
    {
        public RemoveExtraneousDependencies()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            try
            {
                await Instances.SolutionOperations.RemoveExtraneousDependencies(
                    this.SolutionFilePath);

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
