using System;
using System.Threading.Tasks;

using R5T.F0037;


namespace R5T.C0003
{
    partial class Program : ISynchronousProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            F0037.Instances.Program
                .ConfigureServices_Synchronous(async servicesBuilder =>
                {
                    await servicesBuilder.UseServicesConfigurer<ServicesConfigurer>();
                })
                .Run_Synchronous<Program>();
        }
    }
}