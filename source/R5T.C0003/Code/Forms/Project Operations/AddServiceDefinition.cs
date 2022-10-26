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
    public sealed partial class AddServiceDefinition : LayoutForProjectOperation
    {
        private ServiceDefinitionNameModel ServiceDefinitionNameModel { get; }


        public AddServiceDefinition()
        {
            InitializeComponent();

            this.ServiceDefinitionNameModel = new ServiceDefinitionNameModel(
                this.ServiceNameStemTextBox,
                this.ActualServiceNameLabel);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var serviceDefinitionName = this.ServiceDefinitionNameModel.ServiceDefinitionName;

            var serviceDefinitionInterfaceTypeName = F0073.ServiceNameOperator.Instance.GetServiceDefinitionInterfaceTypeName(serviceDefinitionName);

            try
            {
                Instances.ProjectOperations.CreateServiceDefinition(
                    this.SelectProjectFileModel.ProjectFilePath,
                    serviceDefinitionInterfaceTypeName);

                MessageBox.Show("Done!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
