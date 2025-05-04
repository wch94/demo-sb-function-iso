using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace DemoServiceBusFunction;

public class ProcessQueueMessage
{
    private readonly ILogger<ProcessQueueMessage> _logger;

    public ProcessQueueMessage(ILogger<ProcessQueueMessage> logger)
    {
        _logger = logger;
    }

    [Function("ProcessQueueMessage")]
    public void Run([ServiceBusTrigger("demoqueue", Connection = "ServiceBusConnection")] string message)
    {
        _logger.LogInformation($"Received message: {message}");
    }
}
