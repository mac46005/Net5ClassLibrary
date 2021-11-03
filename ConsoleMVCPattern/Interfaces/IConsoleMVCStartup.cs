using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Interfaces{
    public interface IConsoleMVCStartup{
         IHostBuilder CreateBuilder(string[] args);
    } 
}