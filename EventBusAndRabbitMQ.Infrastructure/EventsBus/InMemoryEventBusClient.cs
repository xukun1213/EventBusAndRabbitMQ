namespace EventBusAndRabbitMQ.Infrastructure.EventsBus
{
    public class InMemoryEventBusClient : IEventBus
    {
        public void Publish<T>(T @event) where T : IntegrationEvent
        {
            InMemoryEventBus.Instance.Publish(@event);
        }

        public void Subscribe<T>(IIntegrationEventHandler<T> eventHandler) where T : IntegrationEvent
        {
            InMemoryEventBus.Instance.Subscribe(eventHandler);
        }

        public void StartConsuming()
        {
        }

        public void Dispose()
        {
        }
    }
}