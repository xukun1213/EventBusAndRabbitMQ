using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System;

namespace EventBusAndRabbitMQ.Domain.Events
{
    public class WakeUpDomainEvent : IntegrationEvent
    {
        public WakeUpDomainEvent(Person person) : base(person)
        {
        }

        public WakeUpDomainEvent(Guid id, DateTime occurredOn, Person person) : base(id, occurredOn, person)
        {
        }
    }
}