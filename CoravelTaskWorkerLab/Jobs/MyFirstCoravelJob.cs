using Coravel.Invocable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoravelTaskWorkerLab.Jobs;

internal class MyFirstCoravelJob : IInvocable
{
    readonly ILogger<MyFirstCoravelJob> _logger;

    public MyFirstCoravelJob(ILogger<MyFirstCoravelJob> logger)
    {
        _logger = logger;
    }

    public Task Invoke()
    {
        _logger.LogInformation("這是我的第一支 Coravel Job。");

        return Task.CompletedTask;
    }
}
