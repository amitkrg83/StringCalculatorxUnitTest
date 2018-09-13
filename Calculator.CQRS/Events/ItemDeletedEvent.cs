using System;

namespace Calculator.CQRS.Events
{
    public class ItemDeletedEvent:Event
    {
        public ItemDeletedEvent(Guid aggregateId)
        {
			AggregateId = aggregateId;
        }
    }
}
