using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Domain.Events;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System.Threading.Tasks;

namespace EventBusAndRabbitMQ.Domain.EventHandlers
{
    public class WakeUpDomainEventHandler : IIntegrationEventHandler<WakeUpDomainEvent>
    {
        public Task Handle(WakeUpDomainEvent wakeUpDomainEvent)
        {
            if (wakeUpDomainEvent.EventData is Person person)
            {
                person.WakeUp();
            }
            return Task.CompletedTask;
        }
    }
}