using System;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using R5T.F0036.F001;
using R5T.T0148;


namespace R5T.C0003
{
    public class ServicesConfigurer : IServicesConfigurer
    {
        public Task ConfigureServices(IServiceCollection services)
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            // Configure services.
            F0035.ServicesOperator.Instance.AddLogging(
                services,
                loggingBuilder =>
                {
                    loggingBuilder
                        .AddFile(Instances.FilePaths.LogFilePath)
                        ;
                });

            services
                .AddSingleton<Forms.MainForm>()
                .AddTransient<Forms.Repository.NewLibrary>()
                ;

            return Task.CompletedTask;
        }
    }
}
