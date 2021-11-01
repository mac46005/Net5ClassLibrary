using System.Collections.Generic;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes
{

    public class ConsoleMVCHandler
    {
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
            
        }

    }
}