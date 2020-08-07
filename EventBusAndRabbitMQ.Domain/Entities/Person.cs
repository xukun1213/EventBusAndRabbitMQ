using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusAndRabbitMQ.Domain.Entities
{
    public class Person
    {
        public string Name { get; private set; }

        public Person(string name)
        {
            Name = name;
        }

        public void WakeUp()
        {
            Console.WriteLine($"{Name} was wake up,on {DateTime.UtcNow}");
        }
        public void MorningRun()
        {
            Console.WriteLine($"{Name} is running");
        }
        public void Meeting()
        {
            Console.WriteLine($"{Name} is in Company Meeting");
        }
    }
}
