using System;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.T0132;


namespace R5T.C0003
{
	[FunctionalityMarker]
	public partial interface ITryOperator : IFunctionalityMarker
	{
		public void TryOrShowMessage(
			Action action = default)
		{
			try
			{
				F0000.ActionOperator.Instance.Run(action);
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
			}
		}

        public async Task TryOrShowMessage(
            Func<Task> action = default)
        {
            try
            {
                await F0000.ActionOperator.Instance.Run(action);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        public async Task TryShowDoneOrExceptionMessage(
            Func<Task> action = default)
        {
            try
            {
                await F0000.ActionOperator.Instance.Run(action);

                MessageBox.Show("Done");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}