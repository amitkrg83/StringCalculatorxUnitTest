using Calculator.CQRS.Commands;
using Calculator.CQRS.Storage;
using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator.CQRS.CommandHandlers
{
    public class ChangeItemCommandHandler : ICommandHandler<ChangeItemCommand>
    {
        private readonly IRepository<CalculatorItem> _repository;

        public ChangeItemCommandHandler(IRepository<CalculatorItem> repository)
        {
            _repository = repository;
        }

        public void Execute(ChangeItemCommand command)
        {
            if (command == null)
            {
                throw new ArgumentNullException("command");
            }
            if (_repository == null)
            {
                throw new InvalidOperationException("Repository is not initialized.");
            }

            var aggregate = _repository.GetById(command.Id);

            //Code to be added for calculator set of event(Add, Subtract, division and multiplication)

            _repository.Save(aggregate, command.Version);
        }
    }
}
