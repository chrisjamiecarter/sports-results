using SportsResults.WorkerService.Installers;

namespace SportsResults.WorkerService;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = Host.CreateApplicationBuilder(args);

        // Add services to the container.
        builder.InstallServicesInAssembly();

        var host = builder.Build();
        host.Run();
    }
}