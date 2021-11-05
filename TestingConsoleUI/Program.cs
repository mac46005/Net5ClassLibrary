using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestingConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

        }
        static IHostBuilder CreateHostBuilder<T>(string[] args,T someClass){
            return Host.CreateDefaultBuilder(args);
        }
    }
}
