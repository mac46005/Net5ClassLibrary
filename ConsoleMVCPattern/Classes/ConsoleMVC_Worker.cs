using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConsoleMVCPattern.Interfaces;
using Microsoft.Extensions.Hosting;
namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVC_Worker : BackgroundService
    {
        public ConsoleMVCStartup ConsoleMVCStartup {get;set;}
        private IConsoleController ConsoleController {get;set;}
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }


    }
}