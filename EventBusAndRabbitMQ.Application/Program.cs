using System;
using EventBusAndRabbitMQ.Domain.Entities;
using EventBusAndRabbitMQ.Domain.EventHandlers;
using EventBusAndRabbitMQ.Domain.Events;
using EventBusAndRabbitMQ.Infrastructure.EventsBus;

namespace EventBusAndRabbitMQ.Application
{
    class Program
    {
        private static IEventBus eventBus;
        static void Main(string[] args)
        {
            eventBus = new InMemoryEventBusClient();
            var person = new Person("小明");
            SubscibeEvents(person);

            var wakeUpDomainEvent = new WakeUpDomainEvent(person);
            var runningDomainEvent = new RunningDomainEvent(person);
            var meetDomainEvent = new MeetDomainEvent(person);

            eventBus.Publish(wakeUpDomainEvent);
            eventBus.Publish(runningDomainEvent);
            eventBus.Publish(meetDomainEvent);

            Console.WriteLine("Hello World!");
        }

        private static void SubscibeEvents(Person person)
        {
            var wakeUpDomainEventHandler = new WakeUpDomainEventHandler();
            var runningDomainEventHandler = new RunningDomainEventHandler();
            var meetDomainEventHandler = new MeetDomainEventHandler();

            eventBus.Subscribe(wakeUpDomainEventHandler);
            eventBus.Subscribe(runningDomainEventHandler);
            eventBus.Subscribe(meetDomainEventHandler);
        }
    }
}
