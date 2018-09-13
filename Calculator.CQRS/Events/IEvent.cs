using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}
