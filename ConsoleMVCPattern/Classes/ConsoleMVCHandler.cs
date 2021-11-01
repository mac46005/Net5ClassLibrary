using System.Collections.Generic;
using ConsoleMVCPattern.Interfaces;

namespace ConsoleMVCPattern.Classes
{

    public class ConsoleMVCHandler
    {
        private string controllerStart;
        List<IConsoleController> ConsoleControllerList { get; set; } = new List<IConsoleController>();
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
        private void SetStartingPoint(string controller)
        {

        }
        private void OnControllerEvent(IConsoleController controller){

        }
        private void ChangeEvent(){

        }
    }
}