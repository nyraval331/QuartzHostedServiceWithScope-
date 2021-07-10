using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Quartz;
using System;
using System.Threading.Tasks;

namespace QuartzWithScopedServices
{

    public class HelloCoderJob : IJob
    {
        private readonly ILogger<HelloCoderJob> _logger;

        public HelloCoderJob(ILogger<HelloCoderJob> logger)
        {
            _logger = logger;
        }

        public Task Execute(IJobExecutionContext context)
        {
            _logger.LogInformation("Hello Coder!");
            return Task.CompletedTask;
        }
    }
}
