using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Domain.Events;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System.Threading.Tasks;

namespace EventBusAndRabbitMQ.Domain.EventHandlers
{
    public class RunningDomainEventHandler : IIntegrationEventHandler<RunningDomainEvent>
    {
        public Task Handle(RunningDomainEvent runningDomainEvent)
        {
            if (runningDomainEvent.EventData is Person person)
            {
                person.MorningRun();
            }
            return Task.CompletedTask;
        }
    }
}