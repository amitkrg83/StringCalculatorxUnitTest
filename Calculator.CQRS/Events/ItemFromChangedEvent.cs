﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator.CQRS.Events
{
    public class ItemFromChangedEvent : Event
    {
        public DateTime From { get; internal set; }
        public ItemFromChangedEvent(Guid aggregateId, DateTime from)
        {
			AggregateId = aggregateId;
            From = from;
        }
    }
}
