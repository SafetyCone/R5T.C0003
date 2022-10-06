using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using R5T.F0036.F001;
using R5T.T0148;

using R5T.C0003.Forms;


namespace R5T.C0003
{
    public class ServicesConfigurer : IAsynchronousServicesConfigurer
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configure services.
            services
                .AddLogging(loggingBuilder =>
                {
                    loggingBuilder
                        .SetMinimumLevel(LogLevel.Debug)
                        .AddConsole()
                        .AddFile(Instances.FilePaths.LogFilePath)
                        ;
                })
                .AddTransient<MainForm>()
                ;

            return Task.CompletedTask;
        }
    }
}
