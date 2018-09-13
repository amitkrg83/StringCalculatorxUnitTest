using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.Domain;
using Calculator.CQRS.Domain.Mementos;
using Calculator.CQRS.Events;

namespace Calculator.CQRS.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T: BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}
