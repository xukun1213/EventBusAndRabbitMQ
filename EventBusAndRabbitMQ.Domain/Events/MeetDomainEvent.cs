using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;
using System;

namespace EventBusAndRabbitMQ.Domain.Events
{
    public class MeetDomainEvent : IntegrationEvent
    {
        public MeetDomainEvent(Person person) : base(person)
        {
        }

        public MeetDomainEvent(Guid id, DateTime occurredOn, Person person) : base(id, occurredOn, person)
        {
        }
    }
}