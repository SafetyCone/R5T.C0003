﻿using System;
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
    public sealed partial class ListAllDependencies : LayoutForSolutionOperation
    {
        public ListAllDependencies()
        {
            InitializeComponent();
        }

        private async void RunButton_Click(object sender, EventArgs e)
        {
            await Instances.SolutionOperations.ListAllRecursiveProjectReferences(
                this.SolutionFilePath);
        }
    }
}
