using System.Linq;
using ConsoleMVCPattern.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Classes
{
    public class ConsoleMVCStartupBase
    {
        
        private string _consoleControllerStartUp;
        public void SetConsoleControllerStartUp(string consoleControllerStartUp){
            if(!consoleControllerStartUp.EndsWith("ConsoleController")){

            }
            else{
                _consoleControllerStartUp = consoleControllerStartUp;
            }
        }
        public virtual IServiceCollection ConfigureServices(IServiceCollection services)
        {

            if (services == null)
            {
                services = new ServiceCollection();
                GetType().Assembly.GetTypes()
                .Where(t => t.IsClass)
                .Where(t => t.Name.EndsWith("ConsoleController") | t.Name.EndsWith("ConsoleView") | t.Name.EndsWith("Model"))
                .ToList()
                .ForEach(t => services.AddTransient(t.GetInterface(t.Name), t));
                return services;
            }
            else
            {
                return services;
            }

        }
        
        public virtual IHostBuilder CreateBuilder(string[] args)
        {
            return Host
            .CreateDefaultBuilder(args);
        }
    }
}