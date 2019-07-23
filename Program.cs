using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;

namespace env_repro
{
    class Program
    {
        static void Main(string[] args)
        {
            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostContext, configApp) =>
                {
                    configApp.AddEnvironmentVariables();
                })
            .Build();

            var config = host.Services.GetService(typeof(IConfiguration)) as ConfigurationRoot;
            Console.WriteLine($"The value fetched is: '{config.GetValue<string>("ConnStringWithSemiColons")}'");
        }
    }
}
