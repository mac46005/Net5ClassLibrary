using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVC_Worker : BackgroundService
    {


        private void SubscribeToEvents(){
           GetType().Assembly.GetTypes()
           .Where(t => t.IsClass); 
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }
    }
}