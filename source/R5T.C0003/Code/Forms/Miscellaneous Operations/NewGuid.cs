﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using R5T.F0000;
using R5T.F0062;


namespace R5T.C0003.Forms.Miscellaneous
{
    public partial class NewGuid : LayoutForOperation
    {
        private Guid Guid { get; set; }
        private Func<Guid, string> Formatter { get; set; }


        public NewGuid()
        {
            InitializeComponent();

            this.Formatter = GuidOperator.Instance.ToString_D_Uppercase_Format;

            this.SetGuid(default);
        }
        
        private void SetGuid(Guid guid)
        {
            this.Guid = guid;

            this.SetGuidOutput();
        }
        
        private void SetGuidOutput()
        {
            var guidString = this.Formatter(this.Guid);

            TextBoxOperator.Instance.Set_Value(this.OutputTextBox, guidString);
        }

        public void SetFormatter(Func<Guid, string> formatter)
        {
            this.Formatter = formatter;

            this.SetGuidOutput();
        }

        private void RunButton_Click(object sender, EventArgs e)
        {
            var guid = GuidOperator.Instance.New();

            this.SetGuid(guid);
        }

        private void CopyToClipboardButton_Click(object sender, EventArgs e)
        {
            var text = TextBoxOperator.Instance.Get_Value(
                this.OutputTextBox);

            ClipboardOperator.Instance.SetText(text);
        }

        private void DUpperRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonOperator.Instance.IfChecked(
                this.DUpperRadioButton,
                () => this.SetFormatter(GuidOperator.Instance.ToString_D_Uppercase_Format));
        }

        private void DLowerFormatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonOperator.Instance.IfChecked(
                this.DLowerFormatRadioButton,
                () => this.SetFormatter(GuidOperator.Instance.ToString_D_Format));
        }

        private void NLowerFormatRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButtonOperator.Instance.IfChecked(
                this.NLowerFormatRadioButton,
                () => this.SetFormatter(GuidOperator.Instance.ToString_N_Format));
        }
    }
}
