using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Domain.Events;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System.Threading.Tasks;

namespace EventBusAndRabbitMQ.Domain.EventHandlers
{
    public class MeetDomainEventHandler : IIntegrationEventHandler<MeetDomainEvent>
    {
        public Task Handle(MeetDomainEvent meetDomainEvent)
        {
            if (meetDomainEvent.EventData is Person person)
            {
                person.Meeting();
            }
            return Task.CompletedTask;
        }
    }
}
