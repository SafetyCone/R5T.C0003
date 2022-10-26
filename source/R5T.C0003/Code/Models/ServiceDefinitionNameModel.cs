using System;
using System.Windows.Forms;

using R5T.F0062;


namespace R5T.C0003
{
    public class ServiceDefinitionNameModel : IDisposable
    {
        #region Disposable

        private bool Disposed = false;


        public void Dispose()
        {
            this.Dispose(disposing: true);

            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!this.Disposed)
            {
                if (disposing)
                {
                    TextBoxOperator.Instance.RemoveTextChangedHandler(
                        this.ServiceNameStemTextBox,
                        this.ServiceNameStemTextBox_TextChanged);
                }

                this.Disposed = true;
            }
        }

        ~ServiceDefinitionNameModel()
        {
            this.Dispose(disposing: false);
        }

        #endregion


        public string ServiceDefinitionName { get; set; }

        TextBox ServiceNameStemTextBox { get; }
        Label ActualServiceNameLabel { get; }


        public ServiceDefinitionNameModel(
            TextBox serviceNameStemTextBox,
            Label actualServiceNameLabel)
        {
            this.ServiceNameStemTextBox = serviceNameStemTextBox;
            this.ActualServiceNameLabel = actualServiceNameLabel;

            TextBoxOperator.Instance.AddTextChangedHandler(
                this.ServiceNameStemTextBox,
                this.ServiceNameStemTextBox_TextChanged);

            this.SetDefinitionName();
        }

        private void SetDefinitionName()
        {
            var serviceNameStem = TextBoxOperator.Instance.Get_Value(this.ServiceNameStemTextBox);

            this.ServiceDefinitionName = F0073.ServiceNameOperator.Instance.GetServiceDefinitionName(serviceNameStem);

            LabelOperator.Instance.Set_Value(
                this.ActualServiceNameLabel,
                this.ServiceDefinitionName);
        }

        private void ServiceNameStemTextBox_TextChanged(object sender, EventArgs e)
        {
            this.SetDefinitionName();
        }
    }
}
