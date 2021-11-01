using System.Collections.Generic;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes
{

    public class ConsoleMVCHandler
    {
        public ConsoleMVCHandler(string controlStart)
        {
            SubscribeToControllers();
            SetStartingPoint(controllerStart);
        }
        private void SubscribeToControllers(){
            foreach (IConsoleController controller in ConsoleControllerList)
            {
                controller.ChangeControl += OnControllerEvent;
            }
        }


        private string controllerStart;
        private void SetStartingPoint(string controller)
        {

        }
        private void OnControllerEvent(IConsoleController controller){

        }
        List<IConsoleController> ConsoleControllerList { get; set; } = new List<IConsoleController>();

    }
}