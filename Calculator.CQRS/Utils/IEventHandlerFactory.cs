using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.EventHandlers;
using Calculator.CQRS.Events;

namespace Calculator.CQRS.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}
