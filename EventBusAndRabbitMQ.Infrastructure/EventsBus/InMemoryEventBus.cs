using System;
using System.Collections.Generic;
using System.Linq;

namespace EventBusAndRabbitMQ.Infrastructure.EventsBus
{
    public sealed class InMemoryEventBus
    {
        static InMemoryEventBus()
        {
        }

        private InMemoryEventBus()
        {
            _handlers = new List<HandlerSubscription>();
        }

        private static readonly Lazy<InMemoryEventBus> _instance = new Lazy<InMemoryEventBus>(() => new InMemoryEventBus());
        public static InMemoryEventBus Instance { get { return _instance.Value; } }

        private readonly List<HandlerSubscription> _handlers;

        public void Subscribe<T>(IIntegrationEventHandler<T> eventHandler) where T : IntegrationEvent
        {
            _handlers.Add(new HandlerSubscription(eventHandler, typeof(T).FullName));
        }

        public void Publish<T>(T @event) where T : IntegrationEvent
        {
            var eventType = @event.GetType();

            var integrationEventHandlers = _handlers.Where(x => x.EventName == eventType.FullName).ToList();

            foreach (var eventHandler in integrationEventHandlers)
            {
                if (eventHandler.EventHandler is IIntegrationEventHandler<T> handler)
                {
                    handler.Handle(@event);
                }
            }
        }

        private class HandlerSubscription
        {
            public HandlerSubscription(IIntegrationEventHandler eventHandler, string eventName)
            {
                EventHandler = eventHandler;
                EventName = eventName;
            }

            public IIntegrationEventHandler EventHandler { get; private set; }
            public string EventName { get; private set; }
        }
    }
}