using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.CQRS.Events;

namespace CalculatorCQRS.Storage
{
    public interface IEventPublisher
    {
        void Publish(Event @event);
    }
}
