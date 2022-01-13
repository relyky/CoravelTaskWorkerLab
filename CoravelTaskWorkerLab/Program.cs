using Serilog;
using CoravelTaskWorkerLab;

IHost host = Host.CreateDefaultBuilder(args)
    .ConfigureLogging((ctx, logging) =>
    {
        Log.Logger = new LoggerConfiguration()
            .ReadFrom.Configuration(ctx.Configuration)
            .CreateLogger();

        logging.AddSerilog();
    })
    .ConfigureServices((ctx, services) =>
    {
        services.AddHostedService<Worker>();
    })
    .Build();

await host.RunAsync();
