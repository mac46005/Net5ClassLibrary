using System.Linq;
using ConsoleMVCPattern.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Classes
{
    public class ConsoleMVCStartupBase
    {

        private IHostBuilder ThisHostBuilder {get;}
        static void AddHostedSevice<T>(T host,string[] args){
            Host.CreateDefaultBuilder(args)
            .ConfigureServices((context,services)=> {});
        }
    }
}