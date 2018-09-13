using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Calculator.CQRS.CommandHandlers;
using Calculator.CQRS.Commands;

namespace Calculator.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}
