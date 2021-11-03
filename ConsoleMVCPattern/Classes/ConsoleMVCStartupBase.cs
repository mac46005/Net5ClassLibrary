using ConsoleMVCPattern.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVCStartupBase : IConsoleMVCStartup
    {
        public IServiceCollection ConfigureServices(IServiceCollection service){
            ServiceCollection services = new ServiceCollection();
            return services;
        }
        public virtual IHostBuilder CreateBuilder(string[] args)
        {
            return Host
            .CreateDefaultBuilder(args);
        }
    }
}