using System;
using System.Threading.Tasks;

using R5T.F0037;


namespace R5T.C0003
{
    partial class Program : IAsynchronousProgram
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static async Task Main()
        {
            await F0037.Instances.Program
                .ConfigureServices(servicesBuilder =>
                {
                    servicesBuilder.UseServicesConfigurer<ServicesConfigurer>();
                })
                .Run<Program>();
        }
    }
}