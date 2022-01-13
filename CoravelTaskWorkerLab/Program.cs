using Serilog;
using CoravelTaskWorkerLab;
using Coravel;
using CoravelTaskWorkerLab.Jobs;

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
        services.AddScheduler();
        services.AddTransient<MyFirstCoravelJob>(); // 需預先註冊Job這不太實用。

        //## 註冊 Worker Service 
        //services.AddHostedService<Worker>();
    })
    .UseWindowsService()
    .Build();

host.Services.UseScheduler(scheduler =>
{
    //## 在此設定工作排程。但不易動態設定故不太實用。
    scheduler
        .Schedule<MyFirstCoravelJob>()
        .EveryFiveSeconds()
        .Weekday();
});

await host.RunAsync();
