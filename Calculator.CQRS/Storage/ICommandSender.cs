using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.CQRS.Commands;

namespace CalculatorCQRS.Storage
{
    public interface ICommandSender
    {
        void Send<T>(T command) where T : Command;
    }
}
