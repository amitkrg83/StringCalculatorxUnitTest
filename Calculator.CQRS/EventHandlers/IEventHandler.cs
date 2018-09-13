using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.Events;

namespace Calculator.CQRS.EventHandlers
{
    public interface IEventHandler<TEvent> where TEvent : Event
    {
        void Handle(TEvent handle);
    }
}
