using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using ConsoleMVCPattern.Interfaces;
using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Classes
{

    public class  ConsoleMVC_Worker : BackgroundService
    {
        private object temp {get;set;}
        private string controllerStart;
        List<IConsoleController> ConsoleControllerList { get; set; } = new List<IConsoleController>();
        private void SubscribeToControllers(){
            foreach (IConsoleController controller in ConsoleControllerList)
            {
                controller.ChangeControl += OnControllerEvent;
            }
        }
        public void SetStartingPoint(string controller)
        {


        }















        private void OnControllerEvent(object source,ConsoleControllerEventHandler e){
            StartController(e.ConsoleController);
        }
        private void StartController(IConsoleController controller){
            controller.Initialize();
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }
    }
}