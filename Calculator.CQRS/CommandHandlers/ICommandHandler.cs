using Calculator.CQRS.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.CQRS.CommandHandlers
{
    public interface ICommandHandler<TCommand> where TCommand : Command
    {
        void Execute(TCommand command);
    }
}
