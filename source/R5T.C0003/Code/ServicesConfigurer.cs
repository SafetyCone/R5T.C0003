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
                    var logFilePath = Instances.LogFilePathOperator.GetLogFilePath();

                    loggingBuilder
                        .AddFile(logFilePath)
                        ;
                });

            services
                .AddSingleton<Forms.MainForm>()
                .AddTransient<Forms.Repository.NewConsole>()
                .AddTransient<Forms.Repository.NewConsoleProgramAsService>()
                .AddTransient<Forms.Repository.NewLibrary>()
                .AddTransient<Forms.Repository.NewRepositoryOnly>()
                .AddTransient<Forms.Repository.NewWebApplication>()
                .AddTransient<Forms.Repository.NewWinFormsApplication>()
                ;

            return Task.CompletedTask;
        }
    }
}
