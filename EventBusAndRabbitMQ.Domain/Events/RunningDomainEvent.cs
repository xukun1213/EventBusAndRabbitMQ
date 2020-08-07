using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System;

namespace EventBusAndRabbitMQ.Domain.Events
{
    public class RunningDomainEvent : IntegrationEvent
    {
        public RunningDomainEvent(Person person) : base(person)
        {
        }

        public RunningDomainEvent(Guid id, DateTime occurredOn, Person person) : base(id, occurredOn, person)
        {
        }
    }
}