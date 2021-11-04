using Microsoft.Extensions.Hosting;

namespace ConsoleMVCPattern.Classes{
    public class ConsoleMVCProgram{
        public static void Start(string[] args){
            Host.Build().Run();
        }
        public static IHostBuilder Host {get;set;}
    }
}