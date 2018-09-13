using System;
using Calculator.CQRS.Commands;

namespace Calculator.CQRS.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}
