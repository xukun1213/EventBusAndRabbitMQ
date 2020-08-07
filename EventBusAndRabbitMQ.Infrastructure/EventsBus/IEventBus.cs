using System;

namespace EventBusAndRabbitMQ.Infrastructure.EventsBus
{
    public interface IEventBus : IDisposable
    {
        void Publish<T>(T @event) where T : IntegrationEvent;

        void Subscribe<T>(IIntegrationEventHandler<T> handler) where T : IntegrationEvent;

        void StartConsuming();
    }
}