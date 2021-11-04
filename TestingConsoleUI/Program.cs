using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestingConsoleUI
{
    class Program : BackgroundService
    {
        static void Main(string[] args)
        {

        }
        static IHostBuilder CreateHostBuilder<T>(string[] args,T someClass){
            return Host.CreateDefaultBuilder(args)
            .ConfigureServices((context,services) => {
                services.AddHostedService<Program>();
            });
        }
    }
}
