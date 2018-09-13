using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.Events;
using Calculator.CQRS.Exceptions;
using Calculator.CQRS.Utils;

namespace Calculator.CQRS.Messaging
{
    public class EventBus:IEventBus
    {
        private IEventHandlerFactory _eventHandlerFactory;

        public EventBus(IEventHandlerFactory eventHandlerFactory)
        {
            _eventHandlerFactory = eventHandlerFactory;
        }
        
        public void Publish<T>(T @event) where T : Event
        {
            var handlers = _eventHandlerFactory.GetHandlers<T>();
            foreach (var eventHandler in handlers)
            {
                eventHandler.Handle(@event);
            }
        }
    }
}
