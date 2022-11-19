using System;
using System.Windows.Forms;

using Microsoft.Extensions.Logging;

using R5T.C0003.Forms;


namespace R5T.C0003
{
    partial class Program
    {
        private MainForm MainForm { get; }

        private ILogger Logger { get; }


        public Program(
            MainForm mainForm,
            ILogger<Program> logger)
        {
            this.MainForm = mainForm;

            this.Logger = logger;
        }

        public static void Testing(MainForm mainForm)
        {
            mainForm.SelectOperationNode(Instances.TreeViewNodeNames.NewGuidNode);
        }

        [STAThread]
        public void Run()
        {
            Application.Run(this.MainForm);
        }
    }
}