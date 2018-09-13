using Calculator.CQRS.Domain;
using Calculator.CQRS.Domain.Mementos;
using Calculator.CQRS.Events;
using Calculator.CQRS.Storage.Memento;
using System;
using System.IO;

namespace Calculator.CQRS.CommandHandlers
{
    public class CalculatorItem : AggregateRoot,
        IHandle<CalculatorAddEvent>,
        IOriginator
    {

        public CalculatorItem()
        {

        }

        public CalculatorItem(Guid id)
        {
            ApplyChange(new CalculatorAddEvent(id));
        }


        public void Handle(CalculatorAddEvent e)
        {
            
            Id = e.AggregateId;
           
            Version = e.Version;
        }

        

        public BaseMemento GetMemento()
        {
            return new CalculatorItemMemento(Id, Version);
        }

        public void SetMemento(BaseMemento memento)
        {
            Version = memento.Version;
            Id = memento.Id;
        }


    }
}