using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Auth.Services;

public class App : IHostedService
{
    private readonly IServiceProvider? _serviceProvider;
    private readonly IHost host;

    public App(IServiceProvider? serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }
    public Task StartAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public Task StopAsync(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
