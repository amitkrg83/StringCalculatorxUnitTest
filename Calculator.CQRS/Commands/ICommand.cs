using System;

namespace Calculator.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}
