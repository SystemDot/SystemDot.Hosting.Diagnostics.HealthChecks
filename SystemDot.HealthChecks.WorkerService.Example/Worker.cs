namespace SystemDot.HealthChecks.WorkerService.Example;

public class Worker : BackgroundService
{
    private readonly ILogger<Worker> _logger;

    public Worker(ILogger<Worker> logger)
    {
        _logger = logger;
    }

    protected override async Task ExecuteAsync(CancellationToken stoppingToken)
    {
        _logger.LogInformation("Worker executing at: {time}", DateTimeOffset.Now);
        while (!stoppingToken.IsCancellationRequested)
        {
            _logger.LogDebug("Worker running at: {time}", DateTimeOffset.Now);
            await Task.Delay(1000, stoppingToken);
        }
    }
}