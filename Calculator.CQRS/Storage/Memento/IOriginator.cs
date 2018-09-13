using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.Domain.Mementos;

namespace Calculator.CQRS.Storage.Memento
{
    public interface IOriginator
    {
        BaseMemento GetMemento();
        void SetMemento(BaseMemento memento);
    }
}
