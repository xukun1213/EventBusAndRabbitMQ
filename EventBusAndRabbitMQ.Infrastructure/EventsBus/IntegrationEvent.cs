using System;

namespace EventBusAndRabbitMQ.Infrastructure.EventsBus
{
    public abstract class IntegrationEvent
    {
        public Guid Id { get; }

        public DateTime OccurredOn { get; }

        public object EventData { get; }

        public IntegrationEvent(object eventData)
        {
            this.Id = Guid.NewGuid();
            this.OccurredOn = DateTime.UtcNow;
            this.EventData = eventData;
        }
        protected IntegrationEvent(Guid id, DateTime occurredOn, object eventData) : this(eventData)
        {
            this.Id = id;
            this.OccurredOn = occurredOn;
        }
    }
}