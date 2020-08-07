using System;
using System.Collections.Generic;
using System.Text;

namespace EventBusAndRabbitMQ.Domain.Models
{
    public class WakeUp
    {
        public DateTime WakeUpOn { get; set; }
        public string DoSomething { get; set; }
    }
}
