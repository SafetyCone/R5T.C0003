using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0062;


namespace R5T.C0003.Forms.Project
{
    public partial class AddStronglyTypedType : LayoutForProjectOperation
    {
        public AddStronglyTypedType()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            var projectFilePath = this.SelectProjectFileModel.ProjectFilePath;

            var projectDefaultNamespaceName = F0040.F000.ProjectNamespacesOperator.Instance.GetDefaultNamespaceName_FromProjectFilePath(projectFilePath);

            var baseTypeName = ComboBoxOperator.Instance.Get_ValueString(this.BaseTypeSelectionComboBox);
            var stronglyTypedTypeTypeName = TextBoxOperator.Instance.Get_Value(this.TypeNameTextBox);
            var stronglyTypedTypeDescription = TextBoxOperator.Instance.Get_Value(this.DescriptionTextBox);
            var isDraft = CheckboxOperator.Instance.GetValue(this.IsDraftCheckBox);

            Func<string, string, string, string, bool, Task> createStronglyTypedTypeCodeFileFunction = baseTypeName switch
            {
                "Double" => F0083.CodeFileGenerationOperations.Instance.CreateStronglyTypedDouble,
                "Guid" => F0083.CodeFileGenerationOperations.Instance.CreateStronglyTypedGuid,
                "Integer" => F0083.CodeFileGenerationOperations.Instance.CreateStronglyTypedInteger,
                "String" => F0083.CodeFileGenerationOperations.Instance.CreateStronglyTypedString,
                _ => throw F0000.SwitchOperator.Instance.GetUnrecognizedSwitchValueException(baseTypeName)
            };

            try
            {
                var stronglyTypedTypeCodeFilePath = await F0084.ProjectOperator.Instance.CreateStronglyTypedType(
                    projectFilePath,
                    stronglyTypedTypeTypeName,
                    stronglyTypedTypeDescription,
                    createStronglyTypedTypeCodeFileFunction,
                    isDraft);

                F0033.NotepadPlusPlusOperator.Instance.Open(stronglyTypedTypeCodeFilePath);

                MessageBox.Show("Done!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
