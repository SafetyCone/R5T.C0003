﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0084;
using R5T.L0026;
using R5T.L0026.T000;


namespace R5T.C0003.Forms.Project
{
    public partial class AddInstance : LayoutForProjectOperation, IHasNonWinFormsDesginerSetup
    {
        private Dictionary<string, InstanceTypeInformation> InstanceTypeContentsByTypeName { get; set; }

        private string InstanceTypeName => Instances.ComboBoxOperator.Get_ValueString(
            this.InstanceTypeComboBox);

        private string InstanceTypeNameStem => Instances.TextBoxOperator.Get_Value(
            this.NameTextBox);


        public AddInstance()
        {
            InitializeComponent();
        }

        public void Setup()
        {
            this.InstanceTypeContentsByTypeName = InstanceTypeOperations.Instance.Get_InstanceTypeInformationsByTypeName();

            this.InstanceTypeComboBox.Items.AddRange(
                this.InstanceTypeContentsByTypeName.Keys.ToArray());
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            var projectFilePath = this.SelectProjectFileModel.ProjectFilePath;
            var instanceTypeName = this.InstanceTypeName;
            var instanceTypeNameStem = this.InstanceTypeNameStem;

            var instanceTypeInformation = this.InstanceTypeContentsByTypeName[instanceTypeName];

            async Task Internal()
            {
                await Instances.ProjectOperations.CreateInstancesInProject(
                    projectFilePath,
                    instanceTypeInformation,
                    Instances.EnumerableOperator.From(instanceTypeNameStem));
            }

            await TryOperator.Instance.TryShowDoneOrExceptionMessage(Internal);
        }
    }
}
