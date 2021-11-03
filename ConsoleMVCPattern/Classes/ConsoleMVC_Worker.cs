using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVC_Worker : BackgroundService
    {
        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            throw new System.NotImplementedException();
        }
    }
}