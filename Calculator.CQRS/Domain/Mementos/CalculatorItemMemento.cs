using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.CQRS.Domain.Mementos
{
    public class CalculatorItemMemento : BaseMemento
    {


        public int EventVersion { get; set; }

        public CalculatorItemMemento(Guid id, int version)
        {
            Id = id;
            Version = version;
            EventVersion = version;
        }
    }
}
