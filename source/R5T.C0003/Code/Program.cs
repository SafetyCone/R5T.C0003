using System;
using System.Windows.Forms;

using R5T.C0003.Forms;


namespace R5T.C0003
{
    partial class Program
    {
        private MainForm MainForm { get; }


        public Program(MainForm mainForm)
        {
            this.MainForm = mainForm;
        }

        public static void Testing(MainForm mainForm)
        {
            mainForm.SelectOperationNode(Instances.TreeViewNodeNames.GenerateTailwindCssAllContentPathsFile);
        }

        [STAThread]
        public void Run()
        {
            Application.Run(this.MainForm);
        }
    }
}