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
        public ConsoleMVC_Worker(IConsoleController consoleController)
        {
            if(consoleController.ControllerName() == ConsoleMVCStartup.ConsoleControllerStart){
                ConsoleController = consoleController;
            }
            else{
                throw new Exception("Controller specified not found");
            }
        }
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }


    }
}