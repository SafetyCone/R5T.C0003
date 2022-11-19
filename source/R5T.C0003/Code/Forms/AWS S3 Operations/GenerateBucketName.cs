using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0062;
using R5T.F0074;


namespace R5T.C0003.Forms.AWS.S3
{
    public partial class GenerateBucketName : LayoutForOperation
    {
        public GenerateBucketName()
        {
            InitializeComponent();
        }

        private bool GetIsPublic()
        {
            var isPublic = CheckboxOperator.Instance.GetValue(this.IsPublicCheckBox);
            return isPublic;
        }

        public void SetBucketName(string bucketName)
        {
            TextBoxOperator.Instance.Set_Value(
                this.OutputTextBox,
                bucketName);
        }

        private void GenerateNameAndDisplay()
        {
            var unadjustedBucketName = S3BucketNameOperator.Instance.GetNewRandomBucketName();

            var isPublic = this.GetIsPublic();

            var bucketName = isPublic
                ? S3BucketNameOperator.Instance.MakePublic(unadjustedBucketName)
                : unadjustedBucketName
                ;

            this.SetBucketName(bucketName);
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            this.GenerateNameAndDisplay();
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            var bucketName = TextBoxOperator.Instance.Get_Value(this.OutputTextBox);

            ClipboardOperator.Instance.SetText(bucketName);
        }
    }
}
